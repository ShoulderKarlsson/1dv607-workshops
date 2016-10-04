﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_2.model;
using Workshop_2.view;

namespace Workshop_2.controller
{
    class AddBoatController
    {

        private readonly model.MemberOperations _memberOps;
        private readonly model.MemberCatalog _memberCat;
        private readonly view.AddBoatView _abView;

        public AddBoatController()
        {
            model.Database db = new Database();
            _memberCat = new MemberCatalog(db);
            _memberOps = new MemberOperations(_memberCat, db);
            _abView = new AddBoatView(_memberOps);
        }
        public void CollectInformation()
        {
            string personalNumber = _abView.GetUserPersonalNumber();
            BoatLength bl = _abView.GetBoatLength();
            string bt = _abView.GetBoatType();

            // Will always be int, validating when setting value.
            Boat newBoat = new Boat(bt, int.Parse(bl.Length));
            _memberOps.SaveBoat(newBoat, personalNumber);
        }

    }
}