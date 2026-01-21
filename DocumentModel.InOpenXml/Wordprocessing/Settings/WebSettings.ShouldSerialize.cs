namespace DocumentModel.Wordprocessing;

public partial class WebSettings
{
  public bool ShouldSerializeFrameset() => Frameset is not null;
  public bool ShouldSerializeDivs() => Divs is not null;
  public bool ShouldSerializeWebPageEncoding() => WebPageEncoding is not null;
  public bool ShouldSerializeOptimizeForBrowser() => OptimizeForBrowser is not null;
  public bool ShouldSerializeRelyOnVML() => RelyOnVML is not null;
  public bool ShouldSerializeAllowPNG() => AllowPNG is not null;
  public bool ShouldSerializeDoNotRelyOnCSS() => DoNotRelyOnCSS is not null;
  public bool ShouldSerializeDoNotSaveAsSingleFile() => DoNotSaveAsSingleFile is not null;
  public bool ShouldSerializeDoNotOrganizeInFolder() => DoNotOrganizeInFolder is not null;
  public bool ShouldSerializeDoNotUseLongFileNames() => DoNotUseLongFileNames is not null;
  public bool ShouldSerializePixelsPerInch() => PixelsPerInch is not null;
  public bool ShouldSerializeTargetScreenSize() => TargetScreenSize is not null;
}
