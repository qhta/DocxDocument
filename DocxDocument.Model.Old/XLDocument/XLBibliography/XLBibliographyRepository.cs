using DocumentFormat.OpenXml.Bibliography;
using DocumentFormat.OpenXml.CustomXmlDataProperties;
using DocumentFormat.OpenXml.Packaging;

namespace DocxToLatex.Converter.XLDocument.XLBibliography;

public interface IXLBibliographyRepository
{
  XLBibliographyStyle GetStyle();
  IReadOnlyList<Source> GetSources();
}

public class XLBibliographyRepository : IXLBibliographyRepository
{
  private static readonly Dictionary<string, XLBibliographyStyle> DefaultStyles = new Dictionary<string, XLBibliographyStyle>()
  {
    ["APASixthEditionOfficeOnline.xsl"] = XLBibliographyStyle.APA,
    ["CHICAGO.XSL"] = XLBibliographyStyle.Chicago,
    ["GB.XSL"] = XLBibliographyStyle.GB7714,
    ["GostName.XSL"] = XLBibliographyStyle.Gost,
    ["GostTitle.XSL"] = XLBibliographyStyle.Gost,
    ["HarvardAnglia2008OfficeOnline.xsl"] = XLBibliographyStyle.HarvardAnglia,
    ["IEEE2006OfficeOnline.xsl"] = XLBibliographyStyle.IEEE,
    ["ISO690.XSL"] = XLBibliographyStyle.ISO690,
    ["ISO690Nmerical.XSL"] = XLBibliographyStyle.ISO690Numerical,
    ["MLASeventhEditionOfficeOnline.xsl"] = XLBibliographyStyle.MLA,
    ["SIST02.XSL"] = XLBibliographyStyle.SIST02,
    ["TURABIAN.XSL"] = XLBibliographyStyle.Turabian,
  };

  private readonly IReadOnlyList<Source> sources;
  private readonly XLBibliographyStyle style;

  public XLBibliographyRepository(WordprocessingDocument document)
  {
    if (document.MainDocumentPart != null)
    {
      foreach (CustomXmlPart customXml in document.MainDocumentPart.CustomXmlParts)
      {
        if (customXml.CustomXmlPropertiesPart != null)
        {
          DataStoreItem dsi = customXml.CustomXmlPropertiesPart.DataStoreItem;
          if (dsi.Descendants<SchemaReference>().Single().Uri?.Value?.EndsWith("bibliography") == true)
          {
            Sources sourcesXml = new Sources();
            sourcesXml.Load(customXml);

            this.sources = sourcesXml.ChildElements
              .Cast<Source>()
              .OrderBy(src => int.Parse(src.ReferenceOrder?.Text))
              .ToList();

            var selectedStyle = sourcesXml.SelectedStyle?.Value;
            if (selectedStyle != null)
            {
              var styleFileName = selectedStyle.Substring(selectedStyle.LastIndexOf('\\') + 1);
              if (!DefaultStyles.TryGetValue(styleFileName, out this.style))
                this.style = XLBibliographyStyle.Custom;
            }
            break;
          }
        }
      }
    }
    if (this.sources == null)
    {
      this.sources = Array.Empty<Source>();
    }

  }

  public IReadOnlyList<Source> GetSources()
  {
    return this.sources;
  }

  public XLBibliographyStyle GetStyle()
  {
    return this.style;
  }
}