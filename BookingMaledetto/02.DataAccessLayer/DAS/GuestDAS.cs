﻿using BookingMaledetto._02.DataAccessLayer.Interfaces;
using BookingMaledetto._03.Models.GuestModels;

namespace BookingMaledetto._02.DataAccessLayer.DAS
{
    public class GuestDAS : IGuestDAS
    {
        private readonly BookingMaledettoDbContext _ctx;
        public GuestDAS(BookingMaledettoDbContext ctx)
        {
            _ctx = ctx;
        }

        public Guest AddGuest(Guest guestToAdd)
        {
            var guestAdded = _ctx.Add(guestToAdd);
            _ctx.SaveChanges();
            return guestAdded.Entity;
        }
    }
}
