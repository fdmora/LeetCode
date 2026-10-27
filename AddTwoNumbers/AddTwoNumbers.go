/**
 * Definition for singly-linked list.
 * type ListNode struct {
 *     Val int
 *     Next *ListNode
 * }
 */
func addTwoNumbers(l1 *ListNode, l2 *ListNode) *ListNode {
    dummy := &ListNode{Val: 0}
    current := dummy
    carry := 0

    for l1 != nil || l2 != nil || carry != 0 {
        val1 := 0
        val2 := 0

        if l1 != nil {
            val1 = l1.Val
            l1 = l1.Next
        }

        if l2 != nil {
            val2 = l2.Val
            l2 = l2.Next
        }

        sum := val1 + val2 + carry

        digit := sum % 10
        carry = sum / 10

        current.Next = &ListNode{Val: digit}
        current = current.Next
    }

    return dummy.Next
}