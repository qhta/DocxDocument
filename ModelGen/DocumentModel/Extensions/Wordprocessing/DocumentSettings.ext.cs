namespace DocumentModel.Wordprocessing;

public partial interface DocumentSettings
{
    public DocumentModel.Wordprocessing.Settings? DocSettings { get; set; }
    public DocumentModel.Wordprocessing.WebSettings? WebSettings { get; set; }

    ///// <summary>
    ///// Gets the WordprocessingPrinterSettingsParts of the MainDocumentPart
    ///// </summary>
    //public Collection<DocumentModel.Packaging.WordprocessingPrinterSettingsPart>? WordprocessingPrinterSettingsParts { get; }

    public int Count { get; }

    public object? Get(string propName);

}