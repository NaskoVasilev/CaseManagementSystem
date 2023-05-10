namespace OnlineCourseManagementSystem.Web.ViewModels.Chats
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class CreateChatInputModel
    {
        public string CreatorId { get; set; }

        public IEnumerable<string> FriendsToAdd { get; set; }
    }
}
