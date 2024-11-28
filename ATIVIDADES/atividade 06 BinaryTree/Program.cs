using BinaryTree;
    var tree = BinaryTree<QuizItem>.GetTree();
    BinaryTreeNode<QuizItem> node = tree.Root;
    while (node != null){
        if (node.Left != null || node.Right != null){
            Console.Write(node.Data.Text);
            switch (Console.ReadKey(true).Key){
                case ConsoleKey.Y:
                    BinaryTree<QuizItem>.WriteAnswer(" Yes");
                    node = node.Left;
                    break;
                case ConsoleKey.N:
                    BinaryTree<QuizItem>.WriteAnswer(" No");
                    node = node.Right;
                    break;
            }
        }
        else{
            BinaryTree<QuizItem>.WriteAnswer(node.Data.Text);
            node = null;
        }
    }
