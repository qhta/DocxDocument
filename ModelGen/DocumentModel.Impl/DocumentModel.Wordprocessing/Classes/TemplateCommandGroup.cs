namespace DocumentModel.Wordprocessing;

/// <summary>
/// Defines the TemplateCommandGroup Class.
/// </summary>
public class TemplateCommandGroupImpl: ModelElement<DocumentFormat.OpenXml.Office.Word.TemplateCommandGroup>, TemplateCommandGroup
{
  public Toolbars? Toolbars
  {
    get;
    set;
  }
  
}
