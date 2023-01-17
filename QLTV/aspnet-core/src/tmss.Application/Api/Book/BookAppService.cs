using Abp.Dapper.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;
using tmss.ApiDto.BookDto;
using tmss.Entity;

namespace tmss.Api.Books
{
    public class BookAppService : tmssAppServiceBase
    {
        private readonly IDapperRepository<Sach, int> _bookRepository;
        public BookAppService(
            IDapperRepository<Sach, int> dapperRepository)
        {
            _bookRepository = dapperRepository;
        }

        public async Task<List<BookForViewDto>> GetAll(List<BookForInputDto> input)
        {
            await _bookRepository.ExecuteAsync("SELECT * FROM SACH",new { });
            return null;
        }
    }
}
