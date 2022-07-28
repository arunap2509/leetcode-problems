using Leetcode.Tree;

var node15 = new TreeNode(15);
node15.left = new TreeNode(1);
node15.right = new TreeNode(2);

var node16 = new TreeNode(16);
node16.left = new TreeNode(3);
node16.right = new TreeNode(4);

var node17 = new TreeNode(17);
node17.left = new TreeNode(5);
node17.right = new TreeNode(6);

var node18 = new TreeNode(18);
node18.left = new TreeNode(7);
node18.right = new TreeNode(8);

var node3 = new TreeNode(3);
node3.left = new TreeNode(9);
node3.right = new TreeNode(20);

node3.left.left = node15;
node3.left.right = node16;

node3.right.left = node17;
node3.right.right = node18;

var arr = PreOrderTraversal.Solution(node3);
Console.WriteLine(string.Join(",", arr));