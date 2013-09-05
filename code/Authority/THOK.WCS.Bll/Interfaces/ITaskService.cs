﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using THOK.WCS.DbModel;

namespace THOK.WCS.Bll.Interfaces
{
    public interface ITaskService
    {
        object GetDetails(int page, int rows, Task task);
        bool Add(Task task, out string strResult);
        bool Save(Task task, out string strResult);
        bool Delete(string taskID, out string strResult);
        bool InBillTask(string billNo, out string errInfo);
        bool OutBillTask(string billNo, out string errInfo);
        bool MoveBillTask(string billNo, out string errInfo);

        bool CreateNewTaskFromInBill(string billNo);

        bool CreateNewTaskFromOutBill(string billNo);

        bool CreateNewTaskFromMoveBill(string billNo);

        bool CreateNewTaskFromCheckBill(string billNo);

        bool CreateNewTaskForEmptyPalletStack(int positionID);

        bool CreateNewTaskForEmptyPalletSupply(int positionID);

        bool CreateNewTaskForMoveBackRemain(int taskID);

        bool FinishTask(int taskID);    
        bool FinishTask(int taskID, string orderType, string orderID, int allotID,string originStorageCode, string targetStorageCode);        
    }
}
