﻿using System;
using System.Data.Entity;
using YouConf.Data.Entities;
namespace YouConf.Data
{
    public interface IYouConfDbContext
    {
        DbSet<Conference> Conferences { get; set; }
        DbSet<Presentation> Presentations { get; set; }
        DbSet<Speaker> Speakers { get; set; }
        DbSet<UserProfile> UserProfiles { get; set; }

        int SaveChanges();
    }
}
