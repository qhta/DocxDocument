
namespace DocumentModel.Interop.Core;

/// <summary>
/// Defines methods used by Office document converters.
/// </summary>
/// <remarks>
/// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverter?view=office-pia
/// </remarks>
public partial interface IConverter
{
  /// <summary>
  /// Initializes the converter.
  /// </summary>
  /// <param name="pcap">The `pcap` parameter.</param>
  /// <param name="ppcp">The `ppcp` parameter.</param>
  /// <param name="pcuic">The `pcuic` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverter.hrinitconverter?view=office-pia
  /// </remarks>
  public void HrInitConverter
    (IConverterApplicationPreferences pcap, out IConverterPreferences ppcp, IConverterUICallback pcuic);
  /// <summary>
  /// Uninitializes the converter.
  /// </summary>
  /// <param name="pcuic">The `pcuic` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverter.hruninitconverter?view=office-pia
  /// </remarks>
  public void HrUninitConverter(IConverterUICallback pcuic);
  /// <summary>
  /// Imports content from a source path to a destination path.
  /// </summary>
  /// <param name="bstrSourcePath">The `bstrSourcePath` parameter.</param>
  /// <param name="bstrDestPath">The `bstrDestPath` parameter.</param>
  /// <param name="pcap">The `pcap` parameter.</param>
  /// <param name="ppcp">The `ppcp` parameter.</param>
  /// <param name="pcuic">The `pcuic` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverter.hrimport?view=office-pia
  /// </remarks>
  public void HrImport
  (string bstrSourcePath, string bstrDestPath, IConverterApplicationPreferences pcap, out IConverterPreferences ppcp,
    IConverterUICallback pcuic);
  /// <summary>
  /// Exports content from a source path to a destination path.
  /// </summary>
  /// <param name="bstrSourcePath">The `bstrSourcePath` parameter.</param>
  /// <param name="bstrDestPath">The `bstrDestPath` parameter.</param>
  /// <param name="bstrClass">The `bstrClass` parameter.</param>
  /// <param name="pcap">The `pcap` parameter.</param>
  /// <param name="ppcp">The `ppcp` parameter.</param>
  /// <param name="pcuic">The `pcuic` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverter.hrexport?view=office-pia
  /// </remarks>
  public void HrExport
  (string bstrSourcePath, string bstrDestPath, string bstrClass, IConverterApplicationPreferences pcap,
    out IConverterPreferences ppcp, IConverterUICallback pcuic);
  /// <summary>
  /// Retrieves the converter format class for the specified path.
  /// </summary>
  /// <param name="bstrPath">The `bstrPath` parameter.</param>
  /// <param name="pbstrClass">The `pbstrClass` parameter.</param>
  /// <param name="pcap">The `pcap` parameter.</param>
  /// <param name="ppcp">The `ppcp` parameter.</param>
  /// <param name="pcuic">The `pcuic` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverter.hrgetformat?view=office-pia
  /// </remarks>
  public void HrGetFormat
  (string bstrPath, out string pbstrClass, IConverterApplicationPreferences pcap, out IConverterPreferences ppcp,
    IConverterUICallback pcuic);
  /// <summary>
  /// Retrieves an error message string for an error code.
  /// </summary>
  /// <param name="hrErr">The `hrErr` parameter.</param>
  /// <param name="pbstrErrorMsg">The `pbstrErrorMsg` parameter.</param>
  /// <param name="pcap">The `pcap` parameter.</param>
  /// <remarks>
  /// Microsoft Learn: https://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverter.hrgeterrorstring?view=office-pia
  /// </remarks>
  public void HrGetErrorString(int hrErr, out string pbstrErrorMsg, IConverterApplicationPreferences pcap);
}
