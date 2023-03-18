#include"BinaryTree.h"
using namespace std;

int main()
{
	BinarySearchTree<int> test;
	cin >> test;
	//cout << test;
	
	cout << "\n前序遍历\n";
	test.pre_order();
	cout << "\n中序遍历\n";
	test.in_order();
	cout << "\n后序遍历\n";
	test.post_order();

	cout << "\n树的深度为： " << test.depth();
	cout << "\n树的叶子结点数为： " << test.leafcount();
	cout << "\n树的结点数为为： " << test.nodecount();

	cout << "\n查找最大值: ";
	cout << test.findMax();
	cout << "\n查找最小值: ";
	cout << test.findMin();

	cout << endl;
	cout << test.isEmpty();
	test.makeEmpty();
	cout << endl;
	cout << test.isEmpty();
	return 0;
}