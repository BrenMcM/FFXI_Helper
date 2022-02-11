using FFXI.Entourage_2.Entities;
using FFXI.Entourage_2.Enums;
using System;
using System.Collections.Generic;

namespace FFXI.Entourage_2.Controllers
{
    public static class MemberController
    {

        private static Dictionary<string, Member> _Members;
        public static Dictionary<string, Member> Members
        {
            get { return _Members ?? (_Members = new Dictionary<string, Member>()); }
            set { _Members = value; }
        }

        public static AddMemberResult AddMember(int processId)
        {
            var result = new AddMemberResult();
            var member = new Member(processId);
            Member temp;
            if (Members.TryGetValue(member.Name, out temp))
            {
                result.ResultType = AddMemberResultType.MemberAlreadyExists;
                return result;
            } else
            {
                
                Members.Add(member.Name, member);
                result.MemberName = member.Name;
                result.ResultType = AddMemberResultType.Success;

                return result;
            }
        }

        public static void RemoveMember(string name)
        {
            Member temp;
            if (Members.TryGetValue(name, out temp))
            {
                temp.Dispose();
                Members.Remove(name);
            }
        }

        public static Member GetMember(string name)
        {
            if (name != null)
            {
                Member temp;
                if (Members.TryGetValue(name, out temp))
                {
                    return temp;
                }
            }
            return null;
        }

        public static void AddMemberStatusEventHandler(string name, EventHandler handler)
        {
            Member temp;
            if (Members.TryGetValue(name, out temp))
            {
                Members[name].PlayerStatusChangedHandler += handler;
            }
            else
            {
                throw new System.Exception("Player does not exist");
            }
        }

        public static void RemoveMemberStatusEventHandler(string name, EventHandler handler)
        {
            Member temp;
            if (Members.TryGetValue(name, out temp))
            {
                Members[name].PlayerStatusChangedHandler -= handler;
            }
            else
            {
                throw new System.Exception("Player does not exist");
            }
        }

        public static void AddPluginTimerEventHandler(string name, EventHandler handler)
        {
            Member temp;
            if (Members.TryGetValue(name, out temp))
            {
                Members[name].PluginTimerEventHandler += handler;
            } else
            {
                throw new System.Exception("Player does not exist");
            }
        }

        public static void RemovePluginTimerEventHandler(string name, EventHandler handler)
        {
            Member temp;
            if (Members.TryGetValue(name, out temp))
            {
                Members[name].PluginTimerEventHandler -= handler;
            }
            else
            {
                throw new System.Exception("Player does not exist");
            }
        }
    }
}
