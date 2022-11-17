namespace DocumentModel.Wordprocessing;

public interface IEmbedBoldItalicFont // : DocumentFormat.OpenXml.Wordprocessing.FontRelationshipType
{
  public string? FontKey { get ; set; }
  
  public bool? Subsetted { get ; set; }
  
  public string? Id { get ; set; }
  
}
