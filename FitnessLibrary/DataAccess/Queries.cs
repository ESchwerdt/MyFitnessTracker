using FTLibrary.DataAccess;
using FTLibrary.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FitnessLibrary.DataAccess
{
    public static class Queries
    {
        public static IList<Activity> GetActivities(User user)
        {

            var context = new FitnessContext();

            var userActivities = context.Activities
                .Include("ActivityType")
                .Where(a => a.User.Id == user.Id)
                .OrderByDescending(a => a.ActivityStart)
                .ToList();

            return userActivities;
        }

        public static async Task<IList<Activity>> GetActivitiesAsync(User user)
        {
            var context = new FitnessContext();

            var userActivities = await context.Activities
                .Include("ActivityType")
                .Where(a => a.User.Id == user.Id)
                .OrderByDescending(a => a.ActivityStart)
                .ToListAsync();

            return userActivities;
        }

        public static Activity GetActivity(int actId)
        {
            var context = new FitnessContext();

            //Display native SQL query in console for debugging purposes
            context.Database.Log = Console.Write;

            var userActivity = context.Activities
                .Include("ActivityType")
                .Where(a => a.Id == actId)
                .ToList();
            var activity = userActivity[0];

            return activity;
        }
        public static IList<ActivityType> GetActivityTypes()
        {
            var context = new FitnessContext();

            var availableActivities = context.ActivityTypes.ToList();

            return availableActivities;
        }

    }
}
