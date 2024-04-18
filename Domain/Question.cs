﻿namespace UBB_SE_2024_Team_42.Domain
{
    public class Question(long newPostID, long newUserID, string newTitle, string newCategory, string newContent, DateTime newDatePosted, DateTime newDateOfLastEdit, bool newEditFlag, string newPostType, List<Vote> newVoteList, List<Tag> newTagList) : Post(newPostID, newUserID, newContent, newPostType, newVoteList, newDatePosted, newDateOfLastEdit)
    {
        public string Title { get; set; } = newTitle;
        public string Category { get; } = newCategory;

        public List<Tag> Tags { get; set; } = newTagList;

        public override string ToString()
        {
            return $"Question(postID: {PostID}, userID: {UserID}, title:{Title} , category: {Category}, postType: {PostType}) \n" + $"{Content} \n" + $"votes: {ToStringVoteList()} \n";
        }
    }

}
