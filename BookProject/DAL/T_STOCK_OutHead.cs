﻿/**  版本信息模板在安装目录下，可自行修改。
* T_STOCK_OutHead.cs
*
* 功 能： N/A
* 类 名： T_STOCK_OutHead
*
* Ver    变更日期             负责人  变更内容
* ───────────────────────────────────
* V0.01  2016/1/4 15:02:16   N/A    初版
*
* Copyright (c) 2012 Maticsoft Corporation. All rights reserved.
*┌──────────────────────────────────┐
*│　此技术信息为本公司机密信息，未经本公司书面同意禁止向第三方披露．　│
*│　版权所有：动软卓越（北京）科技有限公司　　　　　　　　　　　　　　│
*└──────────────────────────────────┘
*/
using System;
using System.Data;
using System.Text;
using System.Data.SqlClient;
using Maticsoft.DBUtility;//Please add references
namespace Book.DAL
{
	/// <summary>
	/// 数据访问类:T_STOCK_OutHead
	/// </summary>
	public partial class T_STOCK_OutHead
	{
		public T_STOCK_OutHead()
		{}
		#region  BasicMethod



		/// <summary>
		/// 增加一条数据
		/// </summary>
		public int Add(Book.Model.T_STOCK_OutHead model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("insert into T_STOCK_OutHead(");
			strSql.Append("GuestID,GuestName,CeateTime,UserID,UserName,OrderNumber)");
			strSql.Append(" values (");
			strSql.Append("@GuestID,@GuestName,@CeateTime,@UserID,@UserName,@OrderNumber)");
			strSql.Append(";select @@IDENTITY");
			SqlParameter[] parameters = {
					new SqlParameter("@GuestID", SqlDbType.Int,4),
					new SqlParameter("@GuestName", SqlDbType.NVarChar,50),
					new SqlParameter("@CeateTime", SqlDbType.DateTime),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.NVarChar,50),
					new SqlParameter("@OrderNumber", SqlDbType.NVarChar,50)};
			parameters[0].Value = model.GuestID;
			parameters[1].Value = model.GuestName;
			parameters[2].Value = model.CeateTime;
			parameters[3].Value = model.UserID;
			parameters[4].Value = model.UserName;
			parameters[5].Value = model.OrderNumber;

			object obj = DbHelperSQL.GetSingle(strSql.ToString(),parameters);
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 更新一条数据
		/// </summary>
		public bool Update(Book.Model.T_STOCK_OutHead model)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("update T_STOCK_OutHead set ");
			strSql.Append("GuestID=@GuestID,");
			strSql.Append("GuestName=@GuestName,");
			strSql.Append("CeateTime=@CeateTime,");
			strSql.Append("UserID=@UserID,");
			strSql.Append("UserName=@UserName,");
			strSql.Append("OrderNumber=@OrderNumber");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@GuestID", SqlDbType.Int,4),
					new SqlParameter("@GuestName", SqlDbType.NVarChar,50),
					new SqlParameter("@CeateTime", SqlDbType.DateTime),
					new SqlParameter("@UserID", SqlDbType.Int,4),
					new SqlParameter("@UserName", SqlDbType.NVarChar,50),
					new SqlParameter("@OrderNumber", SqlDbType.NVarChar,50),
					new SqlParameter("@ID", SqlDbType.Int,4)};
			parameters[0].Value = model.GuestID;
			parameters[1].Value = model.GuestName;
			parameters[2].Value = model.CeateTime;
			parameters[3].Value = model.UserID;
			parameters[4].Value = model.UserName;
			parameters[5].Value = model.OrderNumber;
			parameters[6].Value = model.ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}

		/// <summary>
		/// 删除一条数据
		/// </summary>
		public bool Delete(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_STOCK_OutHead ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			int rows=DbHelperSQL.ExecuteSql(strSql.ToString(),parameters);
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}
		/// <summary>
		/// 批量删除数据
		/// </summary>
		public bool DeleteList(string IDlist )
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("delete from T_STOCK_OutHead ");
			strSql.Append(" where ID in ("+IDlist + ")  ");
			int rows=DbHelperSQL.ExecuteSql(strSql.ToString());
			if (rows > 0)
			{
				return true;
			}
			else
			{
				return false;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Book.Model.T_STOCK_OutHead GetModel(int ID)
		{
			
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select  top 1 ID,GuestID,GuestName,CeateTime,UserID,UserName,OrderNumber from T_STOCK_OutHead ");
			strSql.Append(" where ID=@ID");
			SqlParameter[] parameters = {
					new SqlParameter("@ID", SqlDbType.Int,4)
			};
			parameters[0].Value = ID;

			Book.Model.T_STOCK_OutHead model=new Book.Model.T_STOCK_OutHead();
			DataSet ds=DbHelperSQL.Query(strSql.ToString(),parameters);
			if(ds.Tables[0].Rows.Count>0)
			{
				return DataRowToModel(ds.Tables[0].Rows[0]);
			}
			else
			{
				return null;
			}
		}


		/// <summary>
		/// 得到一个对象实体
		/// </summary>
		public Book.Model.T_STOCK_OutHead DataRowToModel(DataRow row)
		{
			Book.Model.T_STOCK_OutHead model=new Book.Model.T_STOCK_OutHead();
			if (row != null)
			{
				if(row["ID"]!=null && row["ID"].ToString()!="")
				{
					model.ID=int.Parse(row["ID"].ToString());
				}
				if(row["GuestID"]!=null && row["GuestID"].ToString()!="")
				{
					model.GuestID=int.Parse(row["GuestID"].ToString());
				}
				if(row["GuestName"]!=null)
				{
					model.GuestName=row["GuestName"].ToString();
				}
				if(row["CeateTime"]!=null && row["CeateTime"].ToString()!="")
				{
					model.CeateTime=DateTime.Parse(row["CeateTime"].ToString());
				}
				if(row["UserID"]!=null && row["UserID"].ToString()!="")
				{
					model.UserID=int.Parse(row["UserID"].ToString());
				}
				if(row["UserName"]!=null)
				{
					model.UserName=row["UserName"].ToString();
				}
				if(row["OrderNumber"]!=null)
				{
					model.OrderNumber=row["OrderNumber"].ToString();
				}
			}
			return model;
		}

		/// <summary>
		/// 获得数据列表
		/// </summary>
		public DataSet GetList(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ID,GuestID,GuestName,CeateTime,UserID,UserName,OrderNumber ");
			strSql.Append(" FROM T_STOCK_OutHead ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获得前几行数据
		/// </summary>
		public DataSet GetList(int Top,string strWhere,string filedOrder)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select ");
			if(Top>0)
			{
				strSql.Append(" top "+Top.ToString());
			}
			strSql.Append(" ID,GuestID,GuestName,CeateTime,UserID,UserName,OrderNumber ");
			strSql.Append(" FROM T_STOCK_OutHead ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			strSql.Append(" order by " + filedOrder);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/// <summary>
		/// 获取记录总数
		/// </summary>
		public int GetRecordCount(string strWhere)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("select count(1) FROM T_STOCK_OutHead ");
			if(strWhere.Trim()!="")
			{
				strSql.Append(" where "+strWhere);
			}
			object obj = DbHelperSQL.GetSingle(strSql.ToString());
			if (obj == null)
			{
				return 0;
			}
			else
			{
				return Convert.ToInt32(obj);
			}
		}
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetListByPage(string strWhere, string orderby, int startIndex, int endIndex)
		{
			StringBuilder strSql=new StringBuilder();
			strSql.Append("SELECT * FROM ( ");
			strSql.Append(" SELECT ROW_NUMBER() OVER (");
			if (!string.IsNullOrEmpty(orderby.Trim()))
			{
				strSql.Append("order by T." + orderby );
			}
			else
			{
				strSql.Append("order by T.ID desc");
			}
			strSql.Append(")AS Row, T.*  from T_STOCK_OutHead T ");
			if (!string.IsNullOrEmpty(strWhere.Trim()))
			{
				strSql.Append(" WHERE " + strWhere);
			}
			strSql.Append(" ) TT");
			strSql.AppendFormat(" WHERE TT.Row between {0} and {1}", startIndex, endIndex);
			return DbHelperSQL.Query(strSql.ToString());
		}

		/*
		/// <summary>
		/// 分页获取数据列表
		/// </summary>
		public DataSet GetList(int PageSize,int PageIndex,string strWhere)
		{
			SqlParameter[] parameters = {
					new SqlParameter("@tblName", SqlDbType.VarChar, 255),
					new SqlParameter("@fldName", SqlDbType.VarChar, 255),
					new SqlParameter("@PageSize", SqlDbType.Int),
					new SqlParameter("@PageIndex", SqlDbType.Int),
					new SqlParameter("@IsReCount", SqlDbType.Bit),
					new SqlParameter("@OrderType", SqlDbType.Bit),
					new SqlParameter("@strWhere", SqlDbType.VarChar,1000),
					};
			parameters[0].Value = "T_STOCK_OutHead";
			parameters[1].Value = "ID";
			parameters[2].Value = PageSize;
			parameters[3].Value = PageIndex;
			parameters[4].Value = 0;
			parameters[5].Value = 0;
			parameters[6].Value = strWhere;	
			return DbHelperSQL.RunProcedure("UP_GetRecordByPage",parameters,"ds");
		}*/

		#endregion  BasicMethod
		#region  ExtensionMethod

		#endregion  ExtensionMethod
	}
}

