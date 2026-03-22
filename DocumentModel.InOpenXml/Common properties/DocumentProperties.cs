namespace DocumentModel;
#pragma warning disable CS1591 // Missing XML comment for publicly visible type or member
/// <summary>
/// Collection of all document properties that is divided to several parts: core properties, 
/// content properties, statistics properties, and custom properties. 
/// Document settings and web settings are also contained in this collection.
/// </summary>
public partial class DocumentProperties: ModelElement
{
  private static readonly Dictionary<string, PropertyInfo> BuildInProperties = new()
  {
    { "Application name", typeof(ContentProperties).GetProperty(nameof(ContentProperties.Application))! },
    { "Author", typeof(CoreProperties).GetProperty(nameof(CoreProperties.Creator))! },
    { "Category", typeof(CoreProperties).GetProperty(nameof(CoreProperties.Category))! },
    { "Comments", typeof(CoreProperties).GetProperty(nameof(CoreProperties.Description))! },
    { "Company", typeof(ContentProperties).GetProperty(nameof(ContentProperties.Company))! },
    { "Content status", typeof(CoreProperties).GetProperty(nameof(CoreProperties.ContentStatus))! },
    { "Content type", typeof(CoreProperties).GetProperty(nameof(CoreProperties.ContentType))! },
    { "Creation date", typeof(CoreProperties).GetProperty(nameof(CoreProperties.Created))! },
    { "Document version", typeof(CoreProperties).GetProperty(nameof(CoreProperties.Version))! },
    { "Format", typeof(ContentProperties).GetProperty(nameof(ContentProperties.PresentationFormat))! },
    { "Hyperlink base", typeof(ContentProperties).GetProperty(nameof(ContentProperties.HyperlinkBase))! },
    { "Keywords", typeof(CoreProperties).GetProperty(nameof(CoreProperties.Keywords))! },
    { "Language", typeof(CoreProperties).GetProperty(nameof(CoreProperties.Language))! },
    { "Last author", typeof(CoreProperties).GetProperty(nameof(CoreProperties.LastModifiedBy))! },
    { "Last print date", typeof(CoreProperties).GetProperty(nameof(CoreProperties.LastPrinted))! },
    { "Last save time", typeof(CoreProperties).GetProperty(nameof(CoreProperties.Modified))! },
    { "Manager", typeof(ContentProperties).GetProperty(nameof(ContentProperties.Manager))! },
    { "Number of bytes", typeof(StatisticProperties).GetProperty(nameof(StatisticProperties.Bytes))! },
    { "Number of characters", typeof(StatisticProperties).GetProperty(nameof(StatisticProperties.Characters))! },
    { "Number of characters (with spaces)", typeof(StatisticProperties).GetProperty(nameof(StatisticProperties.CharactersWithSpaces))! },
    { "Number of hidden Slides", typeof(StatisticProperties).GetProperty(nameof(StatisticProperties.HiddenSlides))! },
    { "Number of lines", typeof(StatisticProperties).GetProperty(nameof(StatisticProperties.Lines))! },
    { "Number of multimedia clips", typeof(StatisticProperties).GetProperty(nameof(StatisticProperties.MultimediaClips))! },
    { "Number of notes", typeof(StatisticProperties).GetProperty(nameof(StatisticProperties.Notes))! },
    { "Number of pages", typeof(StatisticProperties).GetProperty(nameof(StatisticProperties.Pages))! },
    { "Number of paragraphs", typeof(StatisticProperties).GetProperty(nameof(StatisticProperties.Paragraphs))! },
    { "Number of slides", typeof(StatisticProperties).GetProperty(nameof(StatisticProperties.Slides))! },
    { "Number of words", typeof(StatisticProperties).GetProperty(nameof(StatisticProperties.Words))! },
    { "Revision number", typeof(CoreProperties).GetProperty(nameof(CoreProperties.Revision))! },
    { "Security", typeof(ContentProperties).GetProperty(nameof(ContentProperties.DocumentSecurity))! },
    { "Subject", typeof(CoreProperties).GetProperty(nameof(CoreProperties.Subject))! },
    { "Template", typeof(ContentProperties).GetProperty(nameof(ContentProperties.Template))! },
    { "Title", typeof(CoreProperties).GetProperty(nameof(CoreProperties.Title))! },
    { "Total editing time", typeof(StatisticProperties).GetProperty(nameof(StatisticProperties.TotalTime))! },
  };
}