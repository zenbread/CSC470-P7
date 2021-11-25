﻿using System.Collections.Generic;

namespace P6
{
    interface IIssueStatusRepository
    {
        void Add(int Id, string Value);
        List<IssueStatus> GetAll();
        int GetIdByStatus(string value);
        string GetValueById(int Id);
    }
}
