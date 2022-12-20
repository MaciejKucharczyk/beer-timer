using beer_timer.Models;

namespace beer_timer.Interfaces
{
    public interface IRankingService
    {
        List<Ranking> GetRankingList();
        Ranking GetRankingById(int id);
        int CreateRanking(Ranking ranking);
        bool UpdateRanking(int id, Ranking ranking);
        bool DeleteRanking(int id);
    }
}
