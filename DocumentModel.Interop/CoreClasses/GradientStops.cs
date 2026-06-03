using System.Collections;

namespace DocumentModel.Interop.Core;

/// <summary>
/// Represents a collection of GradientStop objects.
/// </summary>
/// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gradientstops?view=office-pia"/>
public partial class GradientStops: InteropCollection<GradientStop>
{


  #region methods

/// <summary>
  /// Deletes a gradient stop from the collection.
  /// </summary>
  /// <param name="index">The `Index` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gradientstops.delete?view=office-pia"/>
  public void Delete(int index) { throw new NotImplementedException(); }
  /// <summary>
  /// Inserts a gradient stop in the collection.
  /// </summary>
  /// <param name="rGB">The `RGB` parameter.</param>
  /// <param name="position">The `Position` parameter.</param>
  /// <param name="transparency">The `Transparency` parameter.</param>
  /// <param name="index">The `Index` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gradientstops.insert?view=office-pia"/>
  public void Insert(int rGB, float position, float transparency, int index) { throw new NotImplementedException(); }
  /// <summary>
  /// Inserts a gradient stop with brightness information.
  /// </summary>
  /// <param name="rGB">The `RGB` parameter.</param>
  /// <param name="position">The `Position` parameter.</param>
  /// <param name="transparency">The `Transparency` parameter.</param>
  /// <param name="index">The `Index` parameter.</param>
  /// <param name="brightness">The `Brightness` parameter.</param>
  /// <seealso cref="http://learn.microsoft.com/en-us/dotnet/api/microsoft.office.core.gradientstops.insert2?view=office-pia"/>
  public void Insert2(int rGB, float position, float transparency, int index, float brightness) { throw new NotImplementedException(); }

  #endregion methods
}

