using DocumentFormat.OpenXml.Packaging;
using DocumentFormat.OpenXml.Wordprocessing;

namespace DocxToLatex.Converter.XLDocument.XLNotes;

public interface IXLNotesRepository
{
  Paragraph GetEndnoteParagraph(long id);
  Paragraph GetFootnoteParagraph(long id);
}

public class XLNotesRepository : IXLNotesRepository
{
  private readonly Endnotes endnotes;
  private readonly Footnotes footnotes;

  public XLNotesRepository(WordprocessingDocument document)
  {
    this.endnotes = document.MainDocumentPart.EndnotesPart?.Endnotes;
    this.footnotes = document.MainDocumentPart.FootnotesPart?.Footnotes;
  }

  public Paragraph GetEndnoteParagraph(long id)
  {
    if (this.endnotes == null)
    {
      return null;
    }

    Endnote endnote = (Endnote)this.endnotes
      .ChildElements
      .Single(e => e is Endnote && ((Endnote)e).Id == id);

    return (Paragraph)endnote.FirstChild;
  }

  public Paragraph GetFootnoteParagraph(long id)
  {
    if (this.footnotes == null)
    {
      return null;
    }

    Footnote footnote = (Footnote)this.footnotes
      .ChildElements
      .Single(e => e is Footnote && ((Footnote)e).Id == id);

    return (Paragraph)footnote.FirstChild;
  }
}