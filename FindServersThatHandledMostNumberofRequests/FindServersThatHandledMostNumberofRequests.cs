using System.Collections.Generic;

public class Solution {
    public IList<int> BusiestServers(int k, int[] arrival, int[] load) {
        var available = new SortedSet<int>();
        var busy = new SortedSet<long>();
        var handled = new int[k];

        for (int server = 0; server < k; server++) {
            available.Add(server);
        }

        for (int request = 0; request < arrival.Length; request++) {
            while (busy.Count > 0 && busy.Min / k <= arrival[request]) {
                long completedRequest = busy.Min;
                available.Add((int)(completedRequest % k));
                busy.Remove(completedRequest);
            }

            if (available.Count == 0) {
                continue;
            }

            int preferredServer = request % k;
            var candidateServers = available.GetViewBetween(preferredServer, k - 1).GetEnumerator();
            int serverToUse = candidateServers.MoveNext() ? candidateServers.Current : available.Min;

            available.Remove(serverToUse);
            handled[serverToUse]++;
            long finishTime = arrival[request] + (long)load[request];
            busy.Add(finishTime * k + serverToUse);
        }

        int maxHandled = 0;
        foreach (int count in handled) {
            if (count > maxHandled) {
                maxHandled = count;
            }
        }

        var busiestServers = new List<int>();
        for (int server = 0; server < k; server++) {
            if (handled[server] == maxHandled) {
                busiestServers.Add(server);
            }
        }

        return busiestServers;
    }
}