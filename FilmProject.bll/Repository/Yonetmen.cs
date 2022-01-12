using MoviesProject.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.bll.Repository
{
    public class Yonetmen
    {
        MoviesEntities db = new MoviesEntities();
        public void Insert(tblDirector Director)
        {
            db.tblDirectors.Add(Director);
            db.SaveChanges();
        }

        public void Delete(int Directorid)
        {
            tblDirector Director = db.tblDirectors.Find(Directorid);
            db.tblDirectors.Remove(Director);
            db.SaveChanges();
        }
        public void Update(tblDirector Director)
        {
            tblDirector Directors = db.tblDirectors.Find(Director.DirectorID);
            db.Entry(Directors).CurrentValues.SetValues(Director);
            db.SaveChanges();
        }
        public List<tblDirector> SelectAll()
        {
            return db.tblDirectors.ToList();
        }
        public tblDirector SelectbyID(int id)
        {
            return db.tblDirectors.Find(id);
        }
        public List<tblDirector> SelectbyId2(int id)
        {
            return db.tblDirectors.Where(p => p.DirectorID == id).ToList();
        }
    }
}
