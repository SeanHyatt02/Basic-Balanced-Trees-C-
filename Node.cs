/**********************************************************************
 *  Project:        Balanced Trees
 *  File:           Node.cs
 *  Language:       C#
 *  
 *  Description:    This file is the Node class for the trees.
 *                  
 *  College:        Husson University
 *  Course:         IT 325
 *  
 *  Change Log
 *  Date        Notes
 *  --------    -------------------------------------
 *  4/11/25    Initial Set Up & Additional Color logic
 *  **/
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HyattBasicTrees {
    
    
    //Enum for color nodes
    public enum Color { Red, Black }

    public class Node {

        #region data
        public int data;
        public Node left;
        public Node right;
        public Node parent;
        public Color color;
        #endregion data

        //Constructor
        public Node(int value) {
            data = value;
            color = Color.Red; // New nodes are red by default
        }
    }
}
