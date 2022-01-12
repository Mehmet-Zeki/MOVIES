using MoviesProject.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.bll.Repository
{
   public class Aktor
    {
        MoviesEntities db = new MoviesEntities();
        public void Insert(tblActor actor)
        {
            db.tblActors.Add(actor);
            db.SaveChanges();
        }

        public void Delete(int actorid)
        {
            tblActor actor = db.tblActors.Find(actorid);
            db.tblActors.Remove(actor);
            db.SaveChanges();
        }
        public void Update(tblActor actor)
        {
            tblActor actors = db.tblActors.Find(actor.ActorID);
            db.Entry(actors).CurrentValues.SetValues(actor);
            db.SaveChanges();
        }
        public List<tblActor> SelectAll()
        {
            return db.tblActors.ToList();
        }
        public tblActor SelectbyID(int id)
        {
            return db.tblActors.Find(id);
        }
        public List<tblActor> SelectbyId2(int id)
        {
            return db.tblActors.Where(p => p.ActorID == id).ToList();
        }
    }
}
