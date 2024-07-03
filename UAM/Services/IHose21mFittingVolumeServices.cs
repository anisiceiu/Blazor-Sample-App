using UAM.Models;

namespace UAM.Services
{
    public interface IHose21mFittingVolumeServices
    {
        
        Task<IEnumerable<Hose21mFittingVolume>> GetHose21mFittingVolume();
        Task<IEnumerable<Hose21mFittingVolume>> GetHose21mFittingVolume(int PageNo);
        Uri GetBaseAddress();
        Task AddHose21mFittingVolume(Hose21mFittingVolume Hose21mFittingVolume);
        Task<Pagination> GetPagination();
    }
}
