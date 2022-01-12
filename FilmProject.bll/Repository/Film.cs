using MoviesProject.dal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilmProject.bll.Repository
{
    public class Film
    {
        MoviesEntities db =new MoviesEntities();
        public void Insert(tblFilm movie)
        {
            db.tblFilms.Add(movie);
            db.SaveChanges();
        }

        public void Delete(int movieid)
        {
            tblFilm movie = db.tblFilms.Find(movieid);
            db.tblFilms.Remove(movie);
            db.SaveChanges();
        }
        public void Update(tblFilm movie)
        {
            tblFilm movies = db.tblFilms.Find(movie.FilmID);
            db.Entry(movies).CurrentValues.SetValues(movie);
            db.SaveChanges();
        }
        public List<tblFilm> SelectAll()
        {
            return db.tblFilms.ToList();
        }
        public tblFilm SelectbyID(int id)
        {
            return db.tblFilms.Find(id);
        }
        public List<tblFilm> SelectbyId2(int id)
        {
            return db.tblFilms.Where(p => p.FilmID == id).ToList();
        }

    }
}
