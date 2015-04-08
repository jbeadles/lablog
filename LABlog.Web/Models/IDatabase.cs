using PetaPoco;
using System;
using System.Collections.Generic;
using System.Data;
namespace LABlog.Web.Models
{
    public interface IDatabase
    {
        void AbortTransaction();
        void BeginTransaction();
        void CloseSharedConnection();
        int CommandTimeout { get; set; }
        void CompleteTransaction();
        IDbConnection Connection { get; }
        IDbCommand CreateCommand(IDbConnection connection, string sql, params object[] args);
        int Delete(object poco);
        int Delete(string tableName, string primaryKeyName, object poco);
        int Delete(string tableName, string primaryKeyName, object poco, object primaryKeyValue);
        int Delete<T>(Sql sql);
        int Delete<T>(object pocoOrPrimaryKey);
        int Delete<T>(string sql, params object[] args);
        void Dispose();
        bool EnableAutoSelect { get; set; }
        bool EnableNamedParams { get; set; }
        int Execute(Sql sql);
        int Execute(string sql, params object[] args);
        T ExecuteScalar<T>(Sql sql);
        T ExecuteScalar<T>(string sql, params object[] args);
        bool Exists<T>(object primaryKey);
        bool Exists<T>(string sqlCondition, params object[] args);
        List<T> Fetch<T>(Sql sql);
        List<T> Fetch<T>(long page, long itemsPerPage, Sql sql);
        List<T> Fetch<T>(long page, long itemsPerPage, string sql, params object[] args);
        List<T> Fetch<T>(string sql, params object[] args);
        List<TRet> Fetch<T1, T2, T3, T4, TRet>(Func<T1, T2, T3, T4, TRet> cb, Sql sql);
        List<TRet> Fetch<T1, T2, T3, T4, TRet>(Func<T1, T2, T3, T4, TRet> cb, string sql, params object[] args);
        List<T1> Fetch<T1, T2, T3, T4>(Sql sql);
        List<T1> Fetch<T1, T2, T3, T4>(string sql, params object[] args);
        List<TRet> Fetch<T1, T2, T3, TRet>(Func<T1, T2, T3, TRet> cb, Sql sql);
        List<TRet> Fetch<T1, T2, T3, TRet>(Func<T1, T2, T3, TRet> cb, string sql, params object[] args);
        List<T1> Fetch<T1, T2, T3>(Sql sql);
        List<T1> Fetch<T1, T2, T3>(string sql, params object[] args);
        List<TRet> Fetch<T1, T2, TRet>(Func<T1, T2, TRet> cb, Sql sql);
        List<TRet> Fetch<T1, T2, TRet>(Func<T1, T2, TRet> cb, string sql, params object[] args);
        List<T1> Fetch<T1, T2>(Sql sql);
        List<T1> Fetch<T1, T2>(string sql, params object[] args);
        T First<T>(Sql sql);
        T First<T>(string sql, params object[] args);
        T FirstOrDefault<T>(Sql sql);
        T FirstOrDefault<T>(string sql, params object[] args);
        string FormatCommand(IDbCommand cmd);
        string FormatCommand(string sql, object[] args);
        ITransaction GetTransaction();
        object Insert(object poco);
        object Insert(string tableName, string primaryKeyName, bool autoIncrement, object poco);
        object Insert(string tableName, string primaryKeyName, object poco);
        bool IsNew(object poco);
        bool IsNew(string primaryKeyName, object poco);
        bool KeepConnectionAlive { get; set; }
        object[] LastArgs { get; }
        string LastCommand { get; }
        string LastSQL { get; }
        void OnBeginTransaction();
        void OnConnectionClosing(IDbConnection conn);
        IDbConnection OnConnectionOpened(IDbConnection conn);
        void OnEndTransaction();
        int OneTimeCommandTimeout { get; set; }
        bool OnException(Exception x);
        void OnExecutedCommand(IDbCommand cmd);
        void OnExecutingCommand(IDbCommand cmd);
        void OpenSharedConnection();
        Page<T> Page<T>(long page, long itemsPerPage, Sql sql);
        Page<T> Page<T>(long page, long itemsPerPage, Sql sqlCount, Sql sqlPage);
        Page<T> Page<T>(long page, long itemsPerPage, string sql, params object[] args);
        Page<T> Page<T>(long page, long itemsPerPage, string sqlCount, object[] countArgs, string sqlPage, object[] pageArgs);
        IEnumerable<T> Query<T>(Sql sql);
        IEnumerable<T> Query<T>(string sql, params object[] args);
        IEnumerable<TRet> Query<T1, T2, T3, T4, TRet>(Func<T1, T2, T3, T4, TRet> cb, Sql sql);
        IEnumerable<TRet> Query<T1, T2, T3, T4, TRet>(Func<T1, T2, T3, T4, TRet> cb, string sql, params object[] args);
        IEnumerable<T1> Query<T1, T2, T3, T4>(Sql sql);
        IEnumerable<T1> Query<T1, T2, T3, T4>(string sql, params object[] args);
        IEnumerable<TRet> Query<T1, T2, T3, TRet>(Func<T1, T2, T3, TRet> cb, Sql sql);
        IEnumerable<TRet> Query<T1, T2, T3, TRet>(Func<T1, T2, T3, TRet> cb, string sql, params object[] args);
        IEnumerable<T1> Query<T1, T2, T3>(Sql sql);
        IEnumerable<T1> Query<T1, T2, T3>(string sql, params object[] args);
        IEnumerable<TRet> Query<T1, T2, TRet>(Func<T1, T2, TRet> cb, Sql sql);
        IEnumerable<TRet> Query<T1, T2, TRet>(Func<T1, T2, TRet> cb, string sql, params object[] args);
        IEnumerable<T1> Query<T1, T2>(Sql sql);
        IEnumerable<T1> Query<T1, T2>(string sql, params object[] args);
        IEnumerable<TRet> Query<TRet>(Type[] types, object cb, string sql, params object[] args);
        void Save(object poco);
        void Save(string tableName, string primaryKeyName, object poco);
        T Single<T>(Sql sql);
        T Single<T>(object primaryKey);
        T Single<T>(string sql, params object[] args);
        T SingleOrDefault<T>(Sql sql);
        T SingleOrDefault<T>(object primaryKey);
        T SingleOrDefault<T>(string sql, params object[] args);
        List<T> SkipTake<T>(long skip, long take, Sql sql);
        List<T> SkipTake<T>(long skip, long take, string sql, params object[] args);
        int Update(object poco);
        int Update(object poco, IEnumerable<string> columns);
        int Update(object poco, object primaryKeyValue);
        int Update(object poco, object primaryKeyValue, IEnumerable<string> columns);
        int Update(string tableName, string primaryKeyName, object poco);
        int Update(string tableName, string primaryKeyName, object poco, IEnumerable<string> columns);
        int Update(string tableName, string primaryKeyName, object poco, object primaryKeyValue);
        int Update(string tableName, string primaryKeyName, object poco, object primaryKeyValue, IEnumerable<string> columns);
        int Update<T>(Sql sql);
        int Update<T>(string sql, params object[] args);
    }
}
