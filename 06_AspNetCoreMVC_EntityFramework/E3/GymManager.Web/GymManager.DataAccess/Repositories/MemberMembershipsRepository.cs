using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GymManager.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace GymManager.DataAccess.Repositories
{
    public class MemberMembershipsRepository : Repository<int, MemberMembership>
    {
        public MemberMembershipsRepository(GymManagerContext context) : base(context) {

        }

        //public async override Task<MemberMembership> AddAsync(MemberMembership entity) {
        //    //Console.WriteLine(entity);
        //    var city = await Context.Cities.FindAsync(entity.City.Id);
        //    Console.WriteLine(city);
        //    entity.City = null;
        //    await Context.Members.AddAsync(entity);
        //    city.Members.Add(entity);

        //    await Context.SaveChangesAsync();
        //    return entity;
        //}

        //public async override Task<MemberMembership> GetAsync(int id) {
        //    var member = await Context.MemberMemberships.FindAsync(id);
        //    Console.WriteLine(member);
        //    return member;
        //}

        public async override Task<IEnumeralbe<Mer> GetMatches(string text) {
            var list = from m in Context.MemberMemberships
                join mm in Context.MemberMemberships on m.Id equals mm.Member.Id
                join ms in Context.MemberMemberships on mm.MemberShipType.Id equals ms.Id

        }
    }
}