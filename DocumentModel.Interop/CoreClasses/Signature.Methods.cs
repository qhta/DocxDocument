
namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents the `Signature` class.
/// </summary>
/// <remarks>
/// See `http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature?view=office-pia` for Office interop details.
/// </remarks>
public partial class Signature
{
  /// <summary>
  /// Invokes `Delete`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.delete?view=office-pia"/>
  public void Delete() { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `Sign`.
  /// </summary>
  /// <param name="varSigImg">The `varSigImg` parameter.</param>
  /// <param name="varDelSuggSigner">The `varDelSuggSigner` parameter.</param>
  /// <param name="varDelSuggSignerLine2">The `varDelSuggSignerLine2` parameter.</param>
  /// <param name="varDelSuggSignerEmail">The `varDelSuggSignerEmail` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.sign?view=office-pia"/>
  public void Sign(object varSigImg, object varDelSuggSigner, object varDelSuggSignerLine2, object varDelSuggSignerEmail) { throw new NotImplementedException(); }
  /// <summary>
  /// Invokes `ShowDetails`.
  /// </summary>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.signature.showdetails?view=office-pia"/>
  public void ShowDetails() { throw new NotImplementedException(); }
}

