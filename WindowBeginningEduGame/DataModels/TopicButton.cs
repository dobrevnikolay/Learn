﻿
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Driver;
using Ninject;
using System;
using System.Linq;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;

namespace WindowBeginningEduGame
{
    public class TopicButton
    {
        #region Public Properties
        [BsonId]
        public ObjectId Id { get; set; }

        /// <summary>
        /// Path to the background picture
        /// </summary>
        public string ImagePath { get; set; }

        /// <summary>
        /// Topic Name, which will be retrieved from the DB
        /// </summary>
        public string Topic { get; set; }

        /// <summary>
        /// If it is false that means that it has been already answered or there is no
        /// data for it in the DB
        /// </summary>
        [BsonIgnore]
        public bool IsAvailable { get; set; } = true;

        #endregion

        #region Public Commands

        /// <summary>
        /// Opens the current topic
        /// </summary>
        public ICommand OpenTheTopic { get; set; }

        #endregion

        #region Constructor

        public TopicButton()
        {
            //read Questions from DB

            OpenTheTopic = new RelayCommand(OpenEduTopic);
        }

        private void OpenEduTopic()
        {
            // Save topic in UserCredentials static field
            // Get topic questions from database
            UserCredentials.CurrentTopic = this.Topic;
            MongoDB.QuestionsCollection.AsQueryable().Where(x => x.Topic == UserCredentials.CurrentTopic).ToList();

            IoC.ControlKernel.Get<ControlViewModel>().CurrentControlContext = ControlContext.Reading;
        }

        #endregion
    }
}
