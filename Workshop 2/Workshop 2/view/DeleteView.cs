﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Workshop_2.model;

namespace Workshop_2.view
{
    class DeleteView : BaseView
    {
        public DeleteView(MemberOperations mOps) : base(mOps) { }

        internal MemberOperations MemberOperations
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public Member Member
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        public void Render()
        {
            Console.WriteLine("Input personal number.");
        }

        protected override void CheckAlreadyExists(string personalNumber)
        {
            if (!_memberOps.IsPersonalNumberTaken(personalNumber))
            {
                throw new Exception("That user does not exist.");
            }
        }

        public void PresentBoats(Member member)
        {
            Console.WriteLine("Select ID of boat to remove");
            foreach (Boat boat in member.MemberBoats)
            {
                Console.WriteLine($"ID: {boat.ID}: {boat}");
            }
        }

        public int GetBoatID()
        {
            return int.Parse(Console.ReadLine());
        }
    }
}
