namespace DocumentModel.Presentation;

public interface ICharRange // : DocumentFormat.OpenXml.Presentation.IndexRangeType
{
  public uint? Start { get ; set; }
  
  public uint? End { get ; set; }
  
}
