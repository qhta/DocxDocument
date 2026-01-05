namespace DocumentModel.Drawings;

/// <summary>
/// Represents a collection of extensions specific to BLIP (Binary Large Image or Picture) elements
/// in DrawingML. These extensions enable enhanced image features, modern image formats, and advanced
/// image processing capabilities while maintaining backward compatibility with older Office versions.
/// </summary>
/// <remarks>
/// <para>
/// <see cref="BlipExtensionList"/> is a specialized extension mechanism for images and pictures embedded
/// in Office Open XML documents. BLIP (Binary Large Image or Picture) is the DrawingML term for image
/// data, and BLIP extensions enable:
/// <list type="bullet">
/// <item><description><b>Modern image formats:</b> Support for WebP, HEIF/HEIC, AVIF, and other emerging formats</description></item>
/// <item><description><b>Advanced compression:</b> Improved compression algorithms and quality settings</description></item>
/// <item><description><b>Image effects:</b> Artistic filters, adjustments, and transformations applied to images</description></item>
/// <item><description><b>SVG support:</b> Vector graphics embedded as images (Office 2016+)</description></item>
/// <item><description><b>HDR images:</b> High dynamic range image support with extended color gamut</description></item>
/// <item><description><b>Animated images:</b> Animated GIF, APNG, or video format support</description></item>
/// <item><description><b>Image metadata:</b> EXIF, IPTC, XMP metadata preservation and management</description></item>
/// </list>
/// </para>
/// <para>
/// BLIP extensions differ from other DrawingML extension types:
/// <list type="bullet">
/// <item><description><b>BlipExtensionList:</b> Specific to image/picture data and image-specific features</description></item>
/// <item><description><b>OfficeArtExtensionList:</b> General DrawingML extensions for shapes, effects, formatting</description></item>
/// <item><description><b>ExtensionList:</b> General-purpose extensions for any Office Open XML element</description></item>
/// </list>
/// This specialization allows image capabilities to evolve independently from other drawing features,
/// adapting to rapidly changing image technology standards.
/// </para>
/// <para>
/// BLIP extensions are commonly used for:
/// <list type="bullet">
/// <item><description><b>Format support:</b> Adding support for image formats not in the original OpenXML specification</description></item>
/// <item><description><b>Quality settings:</b> Enhanced compression options, quality levels, or encoding parameters</description></item>
/// <item><description><b>Image adjustments:</b> Brightness, contrast, saturation, color temperature corrections</description></item>
/// <item><description><b>Effects preservation:</b> Storing pre-processed effects applied before embedding</description></item>
/// <item><description><b>Transparency:</b> Advanced alpha channel handling or masking techniques</description></item>
/// <item><description><b>Color management:</b> ICC profiles, color space definitions, gamut mapping</description></item>
/// <item><description><b>DPI/Resolution:</b> High-DPI image support for Retina/4K displays</description></item>
/// </list>
/// </para>
/// <para>
/// Each <see cref="BlipExtension"/> in the collection typically contains:
/// <list type="bullet">
/// <item><description><b>Extension URI:</b> Unique identifier for the image feature or format</description></item>
/// <item><description><b>Image format data:</b> Format-specific encoding parameters or metadata</description></item>
/// <item><description><b>Processing instructions:</b> How to decode, render, or transform the image</description></item>
/// <item><description><b>Fallback information:</b> Alternative representations for unsupported formats</description></item>
/// <item><description><b>Quality metadata:</b> Original resolution, color depth, compression settings</description></item>
/// </list>
/// </para>
/// <para>
/// BLIP extensions enable Office to support evolving image standards:
/// <list type="bullet">
/// <item><description><b>Office 2010:</b> Enhanced JPEG compression, improved PNG transparency handling</description></item>
/// <item><description><b>Office 2013:</b> Improved image cropping, better compression algorithms</description></item>
/// <item><description><b>Office 2016:</b> SVG support, enhanced image effects pipeline</description></item>
/// <item><description><b>Office 2019:</b> WebP support, improved HDR image handling</description></item>
/// <item><description><b>Microsoft 365:</b> Modern formats (AVIF, HEIF), cloud-optimized images</description></item>
/// </list>
/// </para>
/// <para>
/// Common BLIP extension scenarios include:
/// <list type="bullet">
/// <item><description><b>SVG embedding:</b> Vector graphics stored as images with scalability benefits (Office 2016+)</description></item>
/// <item><description><b>WebP images:</b> Modern web format with superior compression (Office 2019+)</description></item>
/// <item><description><b>HEIF/HEIC:</b> High-efficiency image format from Apple devices (Microsoft 365)</description></item>
/// <item><description><b>Animated GIFs:</b> Animation frame data and playback settings</description></item>
/// <item><description><b>HDR images:</b> Extended color range and tone mapping parameters</description></item>
/// <item><description><b>RAW formats:</b> Camera RAW image support with embedded previews</description></item>
/// <item><description><b>360° images:</b> Panoramic or spherical image metadata</description></item>
/// </list>
/// </para>
/// <para>
/// The BLIP extension mechanism provides several benefits:
/// <list type="bullet">
/// <item><description><b>Graceful degradation:</b> Older Office versions display fallback images while newer versions use enhanced formats</description></item>
/// <item><description><b>Format flexibility:</b> Documents can embed modern image formats without breaking compatibility</description></item>
/// <item><description><b>Progressive enhancement:</b> Images improve visually as Office versions support more features</description></item>
/// <item><description><b>File size optimization:</b> Use efficient modern formats while maintaining legacy support</description></item>
/// <item><description><b>Quality preservation:</b> Store high-quality originals with appropriate fallbacks</description></item>
/// </list>
/// </para>
/// <para>
/// Applications processing BLIP extensions should:
/// <list type="bullet">
/// <item><description><b>Decode supported formats:</b> Render image formats and features your engine supports</description></item>
/// <item><description><b>Provide fallbacks:</b> Use alternative image representations when extensions aren't supported</description></item>
/// <item><description><b>Preserve extensions:</b> Maintain unrecognized extensions for round-trip fidelity</description></item>
/// <item><description><b>Validate image data:</b> Ensure extension content refers to valid, well-formed images</description></item>
/// <item><description><b>Handle metadata:</b> Respect EXIF orientation, color profiles, and other metadata</description></item>
/// <item><description><b>Optimize performance:</b> Cache decoded images, use progressive loading for large images</description></item>
/// </list>
/// </para>
/// <para>
/// BLIP extension patterns include:
/// <list type="bullet">
/// <item><description><b>Format preference:</b> Multiple formats with selection based on decoder availability</description></item>
/// <item><description><b>Quality tiers:</b> Multiple resolutions or quality levels for different use cases</description></item>
/// <item><description><b>Effect chains:</b> Sequence of image processing operations stored as extensions</description></item>
/// <item><description><b>Linked resources:</b> References to external high-resolution versions or source files</description></item>
/// </list>
/// </para>
/// <para>
/// Best practices for BLIP extensions:
/// <list type="bullet">
/// <item><description>Always provide a fallback image in a widely-supported format (JPEG, PNG)</description></item>
/// <item><description>Use modern formats (WebP, AVIF) for smaller file sizes when targeting recent Office versions</description></item>
/// <item><description>Preserve original image metadata (EXIF, color profiles) through extensions</description></item>
/// <item><description>Consider file size impact - extensions add data but can enable better compression</description></item>
/// <item><description>Test image rendering across different Office versions and platforms</description></item>
/// <item><description>Document which image formats and features your application supports</description></item>
/// </list>
/// </para>
/// <para>
/// Technical considerations for BLIP extensions:
/// <list type="bullet">
/// <item><description><b>Memory usage:</b> Large images or many high-resolution images impact memory</description></item>
/// <item><description><b>Decoding performance:</b> Some formats (HEIF, AVIF) require more CPU for decoding</description></item>
/// <item><description><b>Browser compatibility:</b> Web-based Office needs format support in browsers</description></item>
/// <item><description><b>Platform differences:</b> Windows, Mac, iOS, Android may have different decoder support</description></item>
/// <item><description><b>Licensing:</b> Some image formats have licensing requirements or patent considerations</description></item>
/// </list>
/// </para>
/// <para>
/// The BLIP extension system has been crucial for Office's image capabilities:
/// <list type="bullet">
/// <item><description>Enabled adoption of modern image formats without breaking old documents</description></item>
/// <item><description>Allowed Office to benefit from image technology advances (better compression, quality)</description></item>
/// <item><description>Supported diverse image sources (web, mobile devices, professional cameras)</description></item>
/// <item><description>Maintained visual fidelity across different Office versions and platforms</description></item>
/// <item><description>Reduced document file sizes through more efficient image formats</description></item>
/// </list>
/// </para>
/// </remarks>
/// <example>
/// <code>
/// // SVG image with fallback PNG (Office 2016+)
/// var svgExtension = new BlipExtensionList
/// {
///     BlipExtensions = new Collection&lt;BlipExtension&gt;
///     {
///         new BlipExtension
///         {
///             Uri = "{96DAC541-7B7A-43D3-8B79-37D633B846F1}",
///             // Contains SVG image data
///         }
///     }
/// };
/// 
/// // WebP image with quality settings (Office 2019+)
/// var webPExtension = new BlipExtensionList
/// {
///     BlipExtensions = new Collection&lt;BlipExtension&gt;
///     {
///         new BlipExtension
///         {
///             Uri = "{WebPFormat}",
///             // Contains WebP encoding parameters
///         }
///     }
/// };
/// 
/// // Modern multi-format image with HDR and color management
/// var modernImageExtensions = new BlipExtensionList
/// {
///     BlipExtensions = new Collection&lt;BlipExtension&gt;
///     {
///         new BlipExtension
///         {
///             Uri = "{HEIF-Format}",
///             // HEIF/HEIC format data from iPhone
///         },
///         new BlipExtension
///         {
///             Uri = "{HDR-Metadata}",
///             // High dynamic range tone mapping info
///         },
///         new BlipExtension
///         {
///             Uri = "{ICC-Profile}",
///             // Color profile for accurate color reproduction
///         },
///         new BlipExtension
///         {
///             Uri = "{EXIF-Metadata}",
///             // Camera metadata (orientation, timestamp, location)
///         }
///     }
/// };
/// 
/// // Animated image with playback settings
/// var animatedImageExtension = new BlipExtensionList
/// {
///     BlipExtensions = new Collection&lt;BlipExtension&gt;
///     {
///         new BlipExtension
///         {
///             Uri = "{AnimatedGIF}",
///             // Animation frame timing and loop settings
///         },
///         new BlipExtension
///         {
///             Uri = "{PlaybackControl}",
///             // User control over animation playback
///         }
///     }
/// };
/// </code>
/// </example>
public interface BlipExtensionList :
{
  /// <summary>
  /// Gets or sets the collection of BLIP (image) extensions that add support for modern image formats,
  /// advanced image processing features, or image-specific metadata.
  /// </summary>
  /// <remarks>
  /// <para>
  /// The collection of BLIP extensions enables images in Office documents to leverage modern image
  /// technologies while maintaining compatibility with older Office versions. Each extension represents
  /// a specific image enhancement, such as:
  /// <list type="bullet">
  /// <item><description><b>Modern formats:</b> WebP, HEIF/HEIC, AVIF, or other formats not in original OpenXML spec</description></item>
  /// <item><description><b>Vector graphics:</b> SVG support for scalable, resolution-independent images</description></item>
  /// <item><description><b>Advanced compression:</b> Better quality-to-size ratios with modern codecs</description></item>
  /// <item><description><b>Image effects:</b> Pre-applied filters, adjustments, or artistic effects</description></item>
  /// <item><description><b>Metadata preservation:</b> EXIF camera data, GPS coordinates, IPTC copyright info</description></item>
  /// <item><description><b>Color management:</b> ICC color profiles for accurate color reproduction</description></item>
  /// <item><description><b>Transparency:</b> Advanced alpha channel modes or masking techniques</description></item>
  /// <item><description><b>Animation:</b> Frame data and playback settings for animated images</description></item>
  /// <item><description><b>HDR support:</b> Extended color range and tone mapping for HDR displays</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// BLIP extensions are organized by URI to indicate the feature or format:
  /// <list type="bullet">
  /// <item><description><b>Standard GUIDs:</b> Microsoft-defined extensions for Office features (e.g., SVG support)</description></item>
  /// <item><description><b>Format identifiers:</b> URIs identifying specific image formats or codecs</description></item>
  /// <item><description><b>Custom extensions:</b> Third-party or application-specific image features</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The extension collection supports multiple image representation strategies:
  /// <list type="bullet">
  /// <item><description><b>Format alternatives:</b> Multiple image formats (modern + legacy) with automatic selection</description></item>
  /// <item><description><b>Quality tiers:</b> High-quality original with lower-quality preview for performance</description></item>
  /// <item><description><b>Progressive loading:</b> Thumbnail, preview, and full-resolution versions</description></item>
  /// <item><description><b>Platform-specific:</b> Different formats optimized for Windows, Mac, Web, Mobile</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Common extension patterns for BLIP include:
  /// <list type="bullet">
  /// <item><description><b>SVG + PNG:</b> Scalable vector with raster fallback for older versions</description></item>
  /// <item><description><b>WebP + JPEG:</b> Efficient modern format with widely-supported fallback</description></item>
  /// <item><description><b>HEIF + JPEG:</b> High-quality iOS photos with compatibility fallback</description></item>
  /// <item><description><b>RAW + JPEG:</b> Original camera RAW with embedded preview</description></item>
  /// <item><description><b>Effect stack:</b> Original image plus series of effect transformations</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Applications processing BLIP extension collections should:
  /// <list type="bullet">
  /// <item><description><b>Check format support:</b> Determine which image formats your platform/version supports</description></item>
  /// <item><description><b>Select appropriate format:</b> Choose the best supported format from available alternatives</description></item>
  /// <item><description><b>Decode extensions:</b> Parse and apply image features your engine understands</description></item>
  /// <item><description><b>Preserve unknown extensions:</b> Maintain unrecognized extensions for round-trip fidelity</description></item>
  /// <item><description><b>Validate image data:</b> Ensure images are valid and renderable before displaying</description></item>
  /// <item><description><b>Handle errors gracefully:</b> Fall back to standard formats if extensions fail to load</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Image format evolution through extensions:
  /// <list type="bullet">
  /// <item><description><b>Office 2007-2010:</b> Standard JPEG, PNG, GIF, BMP, TIFF support</description></item>
  /// <item><description><b>Office 2013:</b> Improved JPEG compression, enhanced PNG transparency</description></item>
  /// <item><description><b>Office 2016:</b> SVG vector graphics, improved cropping and effects</description></item>
  /// <item><description><b>Office 2019:</b> WebP format support, better HDR handling</description></item>
  /// <item><description><b>Microsoft 365:</b> HEIF/HEIC, AVIF, cloud-optimized formats</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Performance and file size considerations:
  /// <list type="bullet">
  /// <item><description><b>Modern formats:</b> WebP and AVIF typically 30-50% smaller than JPEG at same quality</description></item>
  /// <item><description><b>SVG advantages:</b> Extremely small for graphics/diagrams, scales perfectly to any size</description></item>
  /// <item><description><b>Decode cost:</b> Some formats (HEIF, AVIF) require more CPU/time to decode</description></item>
  /// <item><description><b>Multiple formats:</b> Storing multiple versions increases file size but improves compatibility</description></item>
  /// <item><description><b>Extension overhead:</b> Extension metadata adds minimal size compared to image data</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// Special considerations for specific image types:
  /// <list type="bullet">
  /// <item><description><b>SVG security:</b> SVG can contain scripts; sanitize when embedding external SVGs</description></item>
  /// <item><description><b>Animation control:</b> Provide user controls for animated GIFs (play/pause)</description></item>
  /// <item><description><b>HDR displays:</b> Properly tone-map HDR images for SDR displays</description></item>
  /// <item><description><b>Color accuracy:</b> Apply ICC profiles for professional photography or design</description></item>
  /// <item><description><b>Orientation:</b> Respect EXIF orientation tags for photos from cameras</description></item>
  /// <item><description><b>Privacy:</b> Consider stripping GPS/location data from EXIF metadata</description></item>
  /// </list>
  /// </para>
  /// <para>
  /// The BLIP extension mechanism has enabled Office to:
  /// <list type="bullet">
  /// <item><description>Support modern image formats from smartphones and professional cameras</description></item>
  /// <item><description>Reduce document file sizes significantly through better compression</description></item>
  /// <item><description>Improve visual quality with HDR, wide color gamut, and higher resolutions</description></item>
  /// <item><description>Enable scalable graphics through SVG support</description></item>
  /// <item><description>Maintain compatibility across a decade of Office versions</description></item>
  /// <item><description>Adapt to web standards and modern image technology advances</description></item>
  /// </list>
  /// </para>
  /// </remarks>
  public Collection<BlipExtension>? BlipExtensions { get; set; }
}