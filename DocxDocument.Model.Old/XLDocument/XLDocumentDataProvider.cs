using DocumentFormat.OpenXml.Packaging;

using DocxToLatex.Converter.XLDocument.XLBibliography;
using DocxToLatex.Converter.XLDocument.XLLists;
using DocxToLatex.Converter.XLDocument.XLNotes;
using DocxToLatex.Converter.XLDocument.XLStyles;

namespace DocxToLatex.Converter.XLDocument;

public interface IXLDocumentDataProvider
{
  IXLStyleRepository StyleRepository { get; }
  IXLNotesRepository NotesRepository { get; }
  IXLBibliographyRepository BibliographyRepository { get; }
  IXLListsRepository ListsRepository { get; }
}

public class XLDocumentDataProvider : IXLDocumentDataProvider
{
  public XLDocumentDataProvider(WordprocessingDocument document, string documentName)
  {
    this.StyleRepository = new XLStyleRepository(new XLPropertiesFiller(), document);
    this.NotesRepository = new XLNotesRepository(document);
    this.BibliographyRepository = new XLBibliographyRepository(document);
    this.ListsRepository = new XLListsRepository(document, documentName);
  }

  public IXLStyleRepository StyleRepository { get; }
  public IXLNotesRepository NotesRepository { get; }
  public IXLBibliographyRepository BibliographyRepository { get; }
  public IXLListsRepository ListsRepository { get; }
}