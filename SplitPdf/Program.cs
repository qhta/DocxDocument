namespace SplitPdf
{
  internal class Program
  {
    static void Main(string[] args)
    {
      PdfSplitter.SplitPdf(@"d:\OneDrive\VS\Docs\OpenXML\ISO_IEC_29500-1_2016.pdf",
        @"d:\OneDrive\VS\Docs\OpenXML\",
        [11,12,16,20,23,24,25,26,31,37,38,74,113,137,150,174,179,1533,2526,2729,3191,3609,3810,3815,4141,4415,4416,4418,4421,4422,4498,4499,4509,4542,4548,5026,5034],0);
    }
  }
}
