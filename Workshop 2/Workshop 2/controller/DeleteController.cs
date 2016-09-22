﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_2.model;
using Workshop_2.view;

namespace Workshop_2.controller
{
    class DeleteController
    {
        private model.Database _DAL;
        private view.DeleteView dView;


        public DeleteController()
        {
            _DAL = new Database();
            dView = new DeleteView(_DAL);
        }

        public void CollectInformation()
        {
            dView.Render();
            string personalNumber = dView.GetUserPersonalNumber();
            _DAL.RemoveUser(personalNumber);
        }
    }
}
