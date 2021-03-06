﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// Your custom recording code should go in this file.
// The designer will only add methods to this file, so your custom code won't be overwritten.
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;
using System.Drawing;
using System.Threading;
using WinForms = System.Windows.Forms;

using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

using System.Data;
using System.Linq;
using QLTQ_Chung;

namespace QLTQ
{
    public partial class ThemXaPhuong
    {
    	DataConnectDataContext context;
        /// <summary>
        /// This method gets called right after the recording has been started.
        /// It can be used to execute recording specific initialization code.
        /// </summary>
        private void Init()
        {
            // Your recording specific initialization code goes here.
        }

        public void ValidateXaPhuong(string maXa)
        {
        	context = new DataConnectDataContext();
        	var DB_DMXa = (from yy in context.DanhMucXas where yy.Maxa.Equals(maXa)
        	               select yy).FirstOrDefault();
        	Validate.IsTrue(DB_DMXa!=null, "=========Them moi Danh muc Xa Phuong=========");
        	
            // TODO: Replace the following line with your code implementation.
           // throw new NotImplementedException();
            
        }

        public void XoaXaPhuong(string maXa)
        {
        	context = new DataConnectDataContext();
        	var DB_DMXa = (from yy in context.DanhMucXas where yy.Maxa.Equals(maXa)
        	               select yy).FirstOrDefault();
        	Validate.IsTrue(DB_DMXa==null, "========Them moi Danh muc Xa Phuong==========");
            // TODO: Replace the following line with your code implementation.
           // throw new NotImplementedException();
        }

    }
}
