﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sub_db
{
	internal class FORMS
	{
		/*==============================================================
		 * 执行委托
		 *==============================================================*/
		internal static void	invoke(Action func)
		{
			if(frm_Mainform.m_s_mainform.InvokeRequired)
				frm_Mainform.m_s_mainform.Invoke(func);
			else
				func();
		}
		//--------------------------------------------------
		internal static TResult	invoke<TResult>(Func<TResult> func)
		{
			if(frm_Mainform.m_s_mainform.InvokeRequired)
				return (TResult)frm_Mainform.m_s_mainform.Invoke(func);
			else
				return func();
		}

		/*==============================================================
		 * 激活窗口
		 *==============================================================*/
		internal static void	active_form(Form frm)
		{
			frm.Show();
			frm.BringToFront();
			frm.Activate();
			frm.WindowState = FormWindowState.Normal;
		}

		/*==============================================================
		 * 设置 DoubleBuffered
		 *==============================================================*/
		internal static void	Set_DoubleBuffered(Control c, bool enabled)
		{
			if(c == null)
				return;

			var propertyInfo = typeof(Control).GetProperty(	"DoubleBuffered", 
															System.Reflection.BindingFlags.Instance | System.Reflection.BindingFlags.NonPublic );

			if(propertyInfo == null)
				return;

			propertyInfo.SetValue(c, enabled);
		}
	};
}	// namespace sub_db
