namespace DocumentModel.Wordprocessing;

public interface IEastAsianLayout // : DocumentFormat.OpenXml.TypedOpenXmlLeafElement
{
  public int? Id { get ; set; }

  public bool? Combine { get ; set; }

  public CombineBracket? CombineBrackets { get ; set; }

  public bool? Vertical { get ; set; }

  public bool? VerticalCompress { get ; set; }

}
