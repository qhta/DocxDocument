using DocumentModel.Properties;

namespace DocumentModel.Impl.Extensions.Wordprocessing;

public partial class DocumentSettings
{
    public DocumentModel.Wordprocessing.Settings? DocSettings { get; set; }
    public DocumentModel.Wordprocessing.WebSettings? WebSettings { get; set; }

    ///// <summary>
    ///// Gets the WordprocessingPrinterSettingsParts of the MainDocumentPart
    ///// </summary>
    //public Collection<DocumentModel.Packaging.WordprocessingPrinterSettingsPart>? WordprocessingPrinterSettingsParts { get; }

    public int Count
    {
        get
        {
            int count = 0;
            if (DocSettings != null)
                count += DocSettings.Count;
            if (WebSettings != null)
                count += WebSettings.Count;
            return count;
        }
    }

    public object? Get(string propName)
    {
        var result = CoreProperties?.Get(propName);
        if (result != null) return result;
        result = ExtendedProperties?.Get(propName);
        if (result != null) return result;
        result = CustomProperties?.Get(propName);
        return result;
    }

}