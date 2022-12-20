using beer_timer.Interfaces;
using beer_timer.Models;

namespace beer_timer.Services
{
    public class RankingService : IRankingService
    {
        private readonly DataContext _dataContext;

        public RankingService(DataContext dataContext)
        {
            this._dataContext = dataContext;    
        }

        public int CreateRanking(Ranking ranking)
        {
            _dataContext.Rankings.Add(ranking);
            _dataContext.SaveChanges();
            return ranking.Id;
           
        }

        public bool DeleteRanking(int id)
        {
            var rankingToDelete = _dataContext.Rankings.Find(id);
            if (rankingToDelete == null) {
                return false;
            }
            _dataContext.Rankings.Remove(rankingToDelete);
            _dataContext.SaveChanges();
            return true;
        }

        public Ranking GetRankingById(int id)
        {
            var drinks = _dataContext.Rankings.Find(id);
            return drinks;
        }

        public List<Ranking> GetRankingList()
        {
            var rankings = _dataContext.Rankings.ToList();
            return rankings;
        }

        public bool UpdateRanking(int id, Ranking ranking)
        {
            _dataContext.Rankings.Find(id).Sec=ranking.Sec;
            _dataContext.Rankings.Find(id).Tens=ranking.Tens;
            _dataContext.Rankings.Find(id).Technique=ranking.Technique;
            _dataContext.Rankings.Find(id).UserNameId=ranking.UserNameId;
            return true;
        }
    }
}
