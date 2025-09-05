/**********************************************************************
 *  Project:        Balanced Trees
 *  File:           Tree.cs
 *  Language:       C#
 *  
 *  Description:    This file is the Balanced Tree class.
 *                  
 *  College:        Husson University
 *  Course:         IT 325
 *  
 *  Change Log
 *  Date        Notes
 *  --------    -------------------------------------
 *  4/11/25     Initial Set up/Begin Implementing new functions
 *  4/13/24     Finished code and testing
 *  **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HyattBasicTrees {
    public class Tree {
        #region data
        public Node root;
        #endregion data

        #region methods
        /// <summary>
        /// Public insert method - calls helpers
        /// </summary>
        public void insert(int value) {
            Node newNode = new Node(value);
            BSTInsert(newNode);
            FixInsert(newNode);
        }

        /// <summary>
        /// Binary search tree insert - no color/rotation
        /// </summary>
        private void BSTInsert(Node newNode) {
            Node y = null;  //parent pointer
            Node x = root;

            //Loop through and identify tree spot and insert
            while (x != null) {
                y = x;  //Current node's parent

                //If new value smaller move left, else move right
                if (newNode.data < x.data)
                    x = x.left;
                else if (newNode.data > x.data)
                    x = x.right;
                else {
                    MessageBox.Show(string.Format("Duplicate value: {0}", newNode.data));
                    return;
                }
            }

            //New parent logic 
            newNode.parent = y;

            //If tree empty - new node becomes root
            if (y == null)
                root = newNode;
            else if (newNode.data < y.data)
                y.left = newNode;
            else
                y.right = newNode;
        }

        /// <summary>
        /// Fix tree after insertion to maintain red-black properties
        /// </summary>
        private void FixInsert(Node z) {

            //While z parent is red continue
            while (z.parent != null && z.parent.color == Color.Red) {
                Node grandparent = z.parent.parent;

                //If parent is on left side of grandparent:
                if (z.parent == grandparent.left) {
                    Node uncle = grandparent.right;

                    if (uncle != null && uncle.color == Color.Red) {
                        //Uncle is red – color flip
                        //Re-color parent and uncle to black, GP to red.
                        z.parent.color = Color.Black;
                        uncle.color = Color.Black;
                        grandparent.color = Color.Red;
                        z = grandparent;
                    }
                    else {
                        if (z == z.parent.right) {
                            //Triangle case – left rotate
                            z = z.parent;
                            LeftRotate(z);
                        }
                        //Line case – right rotate
                        z.parent.color = Color.Black;
                        grandparent.color = Color.Red;
                        RightRotate(grandparent);
                    }
                }
                
                //Parent on the right side of grandparent
                else {
                    Node uncle = grandparent.left;

                    //Uncle is red - flip
                    if (uncle != null && uncle.color == Color.Red) {
                        z.parent.color = Color.Black;
                        uncle.color = Color.Black;
                        grandparent.color = Color.Red;
                        z = grandparent;
                    }

                    //Z is left child 
                    else {
                        if (z == z.parent.left) {
                            z = z.parent;
                            RightRotate(z);
                        }
                        z.parent.color = Color.Black;
                        grandparent.color = Color.Red;
                        LeftRotate(grandparent);
                    }
                }
            }
            root.color = Color.Black;
        }

        /// <summary>
        /// Left rotate
        /// </summary>
        private void LeftRotate(Node x) {
            
            //Y = right child of x 
            Node y = x.right;
            x.right = y.left;

          
            if (y.left != null)
                y.left.parent = x;

            y.parent = x.parent;

            if (x.parent == null)
                root = y;
            else if (x == x.parent.left)
                x.parent.left = y;
            else
                x.parent.right = y;

            y.left = x;
            x.parent = y;
        }

        /// <summary>
        /// Right rotate
        /// </summary>
        private void RightRotate(Node y) {
            Node x = y.left;
            y.left = x.right;

            if (x.right != null)
                x.right.parent = y;

            x.parent = y.parent;

            if (y.parent == null)
                root = x;
            else if (y == y.parent.right)
                y.parent.right = x;
            else
                y.parent.left = x;

            x.right = y;
            y.parent = x;
        }

        #endregion methods

    }
}      