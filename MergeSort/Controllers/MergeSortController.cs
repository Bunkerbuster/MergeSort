using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using MergeSortServices.Interfaces;
using MergeSortServices.Helpers;
using MergeSortServices;

namespace MergeSort.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MergeSortController : ControllerBase
    {
        private readonly int[] _UnsortedArray = new[] { 64, 34, 25, 12, 22, 11, 90 };

        private readonly IMergeSortAlgorithm _IMergeSortAlgorithm;

        private readonly ILogger<MergeSortController> _logger;

        public MergeSortController
        (
            ILogger<MergeSortController> logger,
            IMergeSortAlgorithm _ImergesortAlgorithm
        )
        {
            _logger = logger;
            _IMergeSortAlgorithm = _ImergesortAlgorithm;
        }

        [HttpGet("PrintUnsortedArray")]
        public async Task<ActionResult> PrintUnMergedArray()
        {
            return Ok(_UnsortedArray);
        }

        [HttpGet("PrintSortedArray")]
        public async Task<ActionResult> PrintMergedArray()
        {
            int[] _SortedArray = _IMergeSortAlgorithm.MergeSortArray(_UnsortedArray);

            return Ok(_SortedArray);
        }

        [HttpGet("PrintSortedBigArray")]
        public async Task<ActionResult<int[]>> PrintMergedBigArray()
        {

            RandomNumberGeneratorHelper _RandomNumberGeneratorHelper = new RandomNumberGeneratorHelper(1000);

            int[] _UnsortedArray = _RandomNumberGeneratorHelper.Generate();

            _logger.LogInformation("Unsorted Array: " + string.Join(", ", _UnsortedArray));

            int[] _SortedArray = _IMergeSortAlgorithm.MergeSortArray(_UnsortedArray);

            return Ok(_SortedArray);
        }

    }
}