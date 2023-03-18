#ifndef BINARYTREE_H
#define BINARYTREE_H

#include <iostream>
using namespace std;

template <typename Comparable>
class BinarySearchTree
{
public:
    BinarySearchTree() : root(nullptr) {}
    BinarySearchTree(const BinarySearchTree& rhs) : root(rhs) {}
    ~BinarySearchTree()
    {
        makeEmpty(root);
    }

    const Comparable& findMin() const            //查询树中最小元素
    {
        return findMin(root)->element;
    }
    const Comparable& findMax() const            //查询树中最大元素
    {
        return findMax(root)->element;
    }
    bool contains(const Comparable& x) const     //判断树中是否包含已知元素
    {
        contains(x, root);
    }
    bool isEmpty() const      //判断树是否为空
    {
        return root == nullptr;
    }

    int depth()               //求二叉树深度算法
    {
        return depth(root);
    }
    int nodecount()           //求二叉树结点个数算法
    {
        return nodecount(root);
    }
    int leafcount()           //求二叉树叶子节点个数算法
    {
        return leafcount(root);
    }

    void creatTree(istream& in)   //建树
    {
        creatTree(root, in);
    }
    void printTree(ostream& out)  //树的输出
    {
        if (root == nullptr)
        {
            out << "empty tree";
        }
        else
        {
            printTree(root, out);
        }
     
    }
    

    void makeEmpty()             //清空树中所有元素
    {
        if (root == nullptr)
        {
            cout << "empty tree";
        }
        else
        {
            makeEmpty(root);
            root = nullptr;
        }
    }
    void insert(const Comparable& x)     //向树中插入指定元素
    {
        insert(x, root);
    }
    void remove(const Comparable& x)     //删除树中指定元素
    {
        remove(x, root);
    }

    //三种遍历，仅用于输出,若想实现其他功能可引入函数指针实现

    void pre_order() //前序遍历
    {
        pre_order(root);
    }
    void in_order() //中序遍历
    {
        in_order(root);
    }
    void post_order() //后序遍历
    {
        post_order(root);
    }

    const BinarySearchTree& operator=(const BinarySearchTree& rhs)
    {
        if (this != &rhs)
        {
            makeEmpty();
            root = clone(rhs.root);
        }
        return *this;
    }

    //输入输出流运算符重载

    friend istream& operator>>(istream& in, BinarySearchTree<Comparable>& rhs)
    {
        rhs.creatTree(in);
        return in;
    }
    friend ostream& operator<<(ostream& out, BinarySearchTree<Comparable>& rhs)
    {
        rhs.printTree(out);
        return out;
    }

private:
    struct BinaryNode
    {
        Comparable element;
        BinaryNode* left;
        BinaryNode* right;

        BinaryNode(const Comparable& theElement, BinaryNode* lt, BinaryNode* rt)
            : element(theElement), left(lt), right(rt) {}
    };

    BinaryNode* root;

    void insert(const Comparable& x, BinaryNode*& t) const
    {
        if (t == nullptr)
        {
            t = new BinaryNode(x, nullptr, nullptr);
        }
        else if (x < t->element)
        {
            insert(x, t->left);
        }
        else if (x > t->element)
        {
            insert(x, t->right);
        }
    }
    void remove(const Comparable& x, BinaryNode*& t) const
    {
        if (t == nullptr)
        {
            cout << "NULL";
        }
        else if (x < t->element)
        {
            remove(x, t->left);
        }
        else if (x > t->element)
        {
            remove(x, t->right);
        }
        else if (t->left != nullptr && t->right != nullptr)
        {
            t->element = findMin(t->right)->element;
            romove(t->element, t->right);
        }
        else
        {
            BinaryNode* OldNode = t;
            t = (t->left != nullptr) ? t->left : t->right;
            delete OldNode;
        }
    }
    BinaryNode* findMin(BinaryNode* t) const
    {
        if (t == nullptr)
        {
            return 0;
        }
        else if (t->left == nullptr)
        {
            return t;
        }
        return findMin(t->left);
    }
    BinaryNode* findMax(BinaryNode* t) const
    {
        if (t == nullptr)
        {
            return 0;
        }
        else if (t->right == nullptr)
        {
            return t;
        }
        return findMax(t->right);
    }
    bool contains(const Comparable& x, BinaryNode* t) const
    {
        if (t == nullptr)
        {
            return false;
        }
        else if (x < t->element)
        {
            contains(x, t->left);
        }
        else if (x > t->element)
        {
            contains(x, x->right);
        }
        else
        {
            return true;
        }
    }
    void makeEmpty(BinaryNode*& t)
    {
        if(t!=nullptr)
        {
            makeEmpty(t->left);
            makeEmpty(t->right);
            delete t;
        }
    }

    int depth(BinaryNode*& t)
    {
        if (t == nullptr)
            return 0;

        int depth_l = depth(t->left);
        int depth_r = depth(t->right);

        return depth_l > depth_r ? depth_l + 1 : depth_r + 1;
    }
    int nodecount(BinaryNode*& t)
    {
        if (t == nullptr)
            return 0;

        int count_l = nodecount(t->left);
        int count_r = nodecount(t->right);

        return 1 + count_l + count_r;

    }
    int leafcount(BinaryNode*& t)
    {
        if (t == nullptr)
            return 0;
        else if (t->left == 0 && t->right == 0)
            return 1;

        return leafcount(t->right) + leafcount(t->left);
    }

    void creatTree(BinaryNode* t, istream& in)
    {
        Comparable stop, item;

        cout << "请输入树中最后一个元素" << endl;
        in >> stop;
        cout << "请输入树中元素" << endl;
        in >> item;
        while (item != stop)
        {
            insert(item);
            cout << "请输入树中元素" << endl;
            in >> item;
        }
        insert(stop);
    }
    void printTree(BinaryNode* t, ostream& out)
    {
        if (t != nullptr)
        {
            out << (t->element) << " ";
            printTree(t->right, out);
            printTree(t->left, out);
        }
    }

    BinaryNode* clone(BinaryNode* t) const
    {
        if (t == nullptr)
        {
            return nullptr;
        }
        else
        {
            return BinaryNode(t->element, clone(t->left), clone(t - right));
        }
    }

    void pre_order(BinaryNode* t) //前序遍历
    {
        if (t != nullptr)
        {
            cout << t->element << " ";
            pre_order(t->left);
            pre_order(t->right);
        }
    }
    void in_order(BinaryNode* t) //中序遍历
    {
        if (t != nullptr)
        {
            in_order(t->left);
            cout << t->element << " ";
            in_order(t->right);
        }
    }
    void post_order(BinaryNode* t) //后序遍历
    {
        if (t != nullptr)
        {
            post_order(t->left);
            post_order(t->right);
            cout << t->element << " ";
        }
    }
};



#endif 
