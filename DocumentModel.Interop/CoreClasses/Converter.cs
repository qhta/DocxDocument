
namespace DocumentModel.Interop.Core;

/// <summary>
/// Defines methods used by Office document converters.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverter?view=office-pia"/>
public partial class Converter
{


  #region methods

/// <summary>
  /// Initializes the converter.
  /// </summary>
  /// <param name="pcap">The `pcap` parameter.</param>
  /// <param name="ppcp">The `ppcp` parameter.</param>
  /// <param name="pcuic">The `pcuic` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverter.hrinitconverter?view=office-pia"/>
  public void HrInitConverter
    (ConverterApplicationPreferences pcap, out ConverterPreferences ppcp, ConverterUICallback pcuic) { throw new NotImplementedException(); }
  /// <summary>
  /// Uninitializes the converter.
  /// </summary>
  /// <param name="pcuic">The `pcuic` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverter.hruninitconverter?view=office-pia"/>
  public void HrUninitConverter(ConverterUICallback pcuic) { throw new NotImplementedException(); }
  /// <summary>
  /// Imports content from a source path to a destination path.
  /// </summary>
  /// <param name="bstrSourcePath">The `bstrSourcePath` parameter.</param>
  /// <param name="bstrDestPath">The `bstrDestPath` parameter.</param>
  /// <param name="pcap">The `pcap` parameter.</param>
  /// <param name="ppcp">The `ppcp` parameter.</param>
  /// <param name="pcuic">The `pcuic` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverter.hrimport?view=office-pia"/>
  public void HrImport
  (string bstrSourcePath, string bstrDestPath, ConverterApplicationPreferences pcap, out ConverterPreferences ppcp,
    ConverterUICallback pcuic) { throw new NotImplementedException(); }
  /// <summary>
  /// Exports content from a source path to a destination path.
  /// </summary>
  /// <param name="bstrSourcePath">The `bstrSourcePath` parameter.</param>
  /// <param name="bstrDestPath">The `bstrDestPath` parameter.</param>
  /// <param name="bstrClass">The `bstrClass` parameter.</param>
  /// <param name="pcap">The `pcap` parameter.</param>
  /// <param name="ppcp">The `ppcp` parameter.</param>
  /// <param name="pcuic">The `pcuic` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverter.hrexport?view=office-pia"/>
  public void HrExport
  (string bstrSourcePath, string bstrDestPath, string bstrClass, ConverterApplicationPreferences pcap,
    out ConverterPreferences ppcp, ConverterUICallback pcuic) { throw new NotImplementedException(); }
  /// <summary>
  /// Retrieves the converter format class for the specified path.
  /// </summary>
  /// <param name="bstrPath">The `bstrPath` parameter.</param>
  /// <param name="pbstrClass">The `pbstrClass` parameter.</param>
  /// <param name="pcap">The `pcap` parameter.</param>
  /// <param name="ppcp">The `ppcp` parameter.</param>
  /// <param name="pcuic">The `pcuic` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverter.hrgetformat?view=office-pia"/>
  public void HrGetFormat
  (string bstrPath, out string pbstrClass, ConverterApplicationPreferences pcap, out ConverterPreferences ppcp,
    ConverterUICallback pcuic) { throw new NotImplementedException(); }
  /// <summary>
  /// Retrieves an error message string for an error code.
  /// </summary>
  /// <param name="hrErr">The `hrErr` parameter.</param>
  /// <param name="pbstrErrorMsg">The `pbstrErrorMsg` parameter.</param>
  /// <param name="pcap">The `pcap` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.iconverter.hrgeterrorstring?view=office-pia"/>
  public void HrGetErrorString(int hrErr, out string pbstrErrorMsg, ConverterApplicationPreferences pcap) { throw new NotImplementedException(); }

  #endregion methods
}


