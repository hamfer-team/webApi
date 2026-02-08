using Hamfer.WebApi.Core.ContentTypes;

namespace Hamfer.WebApi.Core;

// The `type` represents the general category into which the data type falls.
// The `subtype` identifies the exact kind of data of the specified type the MIME type represents.
// An optional parameter can be added to provide additional details
// MIME type:   type/subtype;parameter=value

public static class WebApiContentType
{
  public const  string MEDIA_TYPE_DELIMITER = "/";
  
// https://www.iana.org/assignments/media-types/media-types.xhtml
  public static readonly Dictionary<string, Dictionary<string,string>> CONTENT_TYPE_IANA = new() 
  {
    #region Discrete types
    { "APPLICATION", ApplicationContentType.ContentTypes },
    { "AUDIO", AudioContentType.ContentTypes },
    { "FONT", FontContentType.ContentTypes },
    { "HAPTICS", HapticsContentType.ContentTypes },
    { "IMAGE", ImageContentType.ContentTypes },
    { "MODEL", ModelContentType.ContentTypes },
    { "TEXT", TextContentType.ContentTypes },
    { "VIDEO", VideoContentTypes.ContentTypes },
    #endregion

    #region Multipart types
    { "MESSAGE", MessageContentType.ContentTypes },
    { "MULTIPART", MultipartContentType.ContentTypes },
    #endregion
  };
  
  public static readonly Dictionary<string, string> ContentTypes = new()
  {
  	//#region WEB
    {"CSS", CONTENT_TYPE_IANA["TEXT"]["css"]},   // CSS files used to style a Web page must be sent with text/css.
    {"CSV", CONTENT_TYPE_IANA["TEXT"]["csv"]},
    {"HTML", CONTENT_TYPE_IANA["TEXT"]["html"]},
    {"JS", CONTENT_TYPE_IANA["TEXT"]["javascript"]},
    {"JSON", CONTENT_TYPE_IANA["APPLICATION"]["json"]},
    {"JSONLD", CONTENT_TYPE_IANA["APPLICATION"]["ld+json"]},   // JSON-LD format
    {"MJS", CONTENT_TYPE_IANA["TEXT"]["javascript"]},   // JavaScript module
    {"PHP", "application/x-httpd-php"},   // Hypertext Preprocessor (Personal Home Page)
    {"WEB_MANIFEST", CONTENT_TYPE_IANA["APPLICATION"]["manifest+json"]},   // Web application manifest
    {"XHTML", CONTENT_TYPE_IANA["APPLICATION"]["xhtml+xml"]},

    {"ANY_APPLICATION", "application/*"},
	  //#endregion

	  //#region COMPRESSED
	  {"7Z", "application/x-7z-compressed"},
    {"ARC", "application/x-freearc"},   //Archive document (multiple files embedded)
    {"BZ", "application/x-bzip"},   // BZip archive
    {"BZ2", "application/x-bzip2"},   // BZip2 archive
    {"GZ", CONTENT_TYPE_IANA["APPLICATION"]["gzip"]},   // GZip Compressed Archive
    {"GZ_ALT", "application/x-gzip"},
    {"JAR", CONTENT_TYPE_IANA["APPLICATION"]["java-archive"]}, // Java Archive (JAR)
    {"MPKG", CONTENT_TYPE_IANA["APPLICATION"]["vnd.apple.installer+xml"]},   // Apple Installer Package
    {"RAR", CONTENT_TYPE_IANA["APPLICATION"]["vnd.rar"]},
    {"RAR_ALT", "application/x-rar-compressed"},
    {"TAR", "application/x-tar"},   // Tape Archive (TAR)
    {"ZIP", CONTENT_TYPE_IANA["APPLICATION"]["zip"]},
    {"ZIP_ALT", "application/x-zip-compressed"},
	//#endregion
  
	//#region DOCUMENTS
    {"ABW", "application/x-abiword"},   // AbiWord document
    {"AZW", "application/vnd.amazon.ebook"},    // Amazon Kindle eBook format
    {"DOC", CONTENT_TYPE_IANA["APPLICATION"]["msword"]},
    {"DOCX", CONTENT_TYPE_IANA["APPLICATION"]["vnd.openxmlformats-officedocument.wordprocessingml.document"]},
    {"EPUB", CONTENT_TYPE_IANA["APPLICATION"]["epub+zip"]},    // Electronic publication (EPUB)
    {"ICS", "text/calendar"},   // iCalendar format
    {"MD", CONTENT_TYPE_IANA["TEXT"]["markdown"]},
    {"ODP", CONTENT_TYPE_IANA["APPLICATION"]["vnd.oasis.opendocument.presentation"]},    // OpenDocument presentation document
    {"ODS", CONTENT_TYPE_IANA["APPLICATION"]["vnd.oasis.opendocument.spreadsheet"]},    // OpenDocument spreadsheet document
    {"ODT", CONTENT_TYPE_IANA["APPLICATION"]["vnd.oasis.opendocument.text"]},    // OpenDocument text document
    {"PDF", CONTENT_TYPE_IANA["APPLICATION"]["pdf"]},
    {"PPT", CONTENT_TYPE_IANA["APPLICATION"]["vnd.ms-powerpoint"]},
    {"PPTX", CONTENT_TYPE_IANA["APPLICATION"]["vnd.openxmlformats-officedocument.presentationml.presentation"]},
    {"RTF", CONTENT_TYPE_IANA["APPLICATION"]["rtf"]},
    {"VSD", CONTENT_TYPE_IANA["APPLICATION"]["vnd.visio"]},
    {"XLS", CONTENT_TYPE_IANA["APPLICATION"]["vnd.ms-excel"]},
    {"XLSX", CONTENT_TYPE_IANA["APPLICATION"]["vnd.openxmlformats-officedocument.spreadsheetml.sheet"]},
    {"XML", CONTENT_TYPE_IANA["APPLICATION"]["xml"]},
    {"XML_ALT", CONTENT_TYPE_IANA["TEXT"]["xml"]},
    {"XML_ATOM", CONTENT_TYPE_IANA["APPLICATION"]["atom+xml"]},

    {"ANY_TEXT", "text/*"},
	//#endregion
  
	//#region IMAGE
    {"APNG", CONTENT_TYPE_IANA["IMAGE"]["apng"]},   // Animated Portable Network Graphics
    {"AVIF", CONTENT_TYPE_IANA["IMAGE"]["avif"]},
    {"BMP", CONTENT_TYPE_IANA["IMAGE"]["bmp"]},
    {"GIF", CONTENT_TYPE_IANA["IMAGE"]["gif"]},   // Graphics Interchange Format (GIF)
    {"ICON", CONTENT_TYPE_IANA["IMAGE"]["vnd.microsoft.icon"]},
    {"JPEG", CONTENT_TYPE_IANA["IMAGE"]["jpeg"]},
    {"JPG", CONTENT_TYPE_IANA["IMAGE"]["jpeg"]},
    {"PNG", CONTENT_TYPE_IANA["IMAGE"]["png"]},
    {"SVG", CONTENT_TYPE_IANA["IMAGE"]["svg+xml"]},    // Scalable Vector Graphics (SVG)
    {"TIFF", CONTENT_TYPE_IANA["IMAGE"]["tiff"]},   // Tagged Image File Format (TIFF)
    {"WEBP", CONTENT_TYPE_IANA["IMAGE"]["webp"]},

    {"ANY_IMAGE", "image/*"},
	//#endregion

	//#region AUDIO
    {"3G2_AUDIO", CONTENT_TYPE_IANA["AUDIO"]["3gpp2"]},
    {"3GP_AUDIO", CONTENT_TYPE_IANA["AUDIO"]["3gpp"]},
    {"AAC", CONTENT_TYPE_IANA["AUDIO"]["aac"]},
    {"MP3", CONTENT_TYPE_IANA["AUDIO"]["mpeg"]},
    {"CDA", "application/x-cdf"},   // CD audio
    {"MIDI", "audio/x-midi"},   // Musical Instrument Digital Interface (MIDI)
    {"MIDI_ALT", "audio/midi"},
    {"OGA", CONTENT_TYPE_IANA["AUDIO"]["ogg"]},
    {"OPUS", CONTENT_TYPE_IANA["AUDIO"]["ogg"]},
    {"WAV", "audio/wav"},   // Waveform Audio Format
    {"WEBA", "audio/webm"},

    {"ANY_AUDIO", "audio/*"},
	//#endregion
  
	//#region VIDEO
    {"3G2", CONTENT_TYPE_IANA["VIDEO"]["3gpp2"]},
    {"3GP", CONTENT_TYPE_IANA["VIDEO"]["3gpp"]},
    {"AVI", "video/x-msvideo"},   //    {"AVI", Audio Video Interleave
    {"AVI_ALT", "video/avi"},
    {"MP4", CONTENT_TYPE_IANA["VIDEO"]["mp4"]},
    {"MPEG", CONTENT_TYPE_IANA["VIDEO"]["mpeg"]},
    {"OGV", CONTENT_TYPE_IANA["VIDEO"]["ogg"]},
    {"TS", CONTENT_TYPE_IANA["VIDEO"]["MP2T"]},     // MPEG transport stream
    {"WEBM", "video/webm"},
  
    {"ANY_VIDEO", "video/*"},
	//#endregion
  
	//#region FONT
    {"EOT", CONTENT_TYPE_IANA["APPLICATION"]["vnd.ms-fontobject"]},   // MS Embedded OpenType fonts
    {"OTF", CONTENT_TYPE_IANA["FONT"]["otf"]},
    {"TTF", CONTENT_TYPE_IANA["FONT"]["ttf"]},    // TrueType Font
    {"WOFF", CONTENT_TYPE_IANA["FONT"]["woff"]},   // Web Open Font Format (WOFF)
    {"WOFF2", CONTENT_TYPE_IANA["FONT"]["woff2"]},
  
    {"ANY_FONT", "font/*"},
	//#endregion
    
	//#region OTHERS
    {"CSH", "application/x-csh"},   // C-Shell script
    {"SH", "application/x-sh"},   // Bourne shell script
	//#endregion

    {"FORM_URLENCODED", CONTENT_TYPE_IANA["APPLICATION"]["x-www-form-urlencoded"]},
    {"FORM_DATA", CONTENT_TYPE_IANA["MULTIPART"]["form-data"]},
  
    {"ANY", "*/*"},
    {"TEXT", CONTENT_TYPE_IANA["TEXT"]["plain"]},    // For text documents without a specific subtype, text/plain should be used.
    {"BINARY", CONTENT_TYPE_IANA["APPLICATION"]["octet-stream"]}, // Any kind of binary data.
    {"UNRECOGNIZED", CONTENT_TYPE_IANA["APPLICATION"]["octet-stream"]}, // For binary documents without a specific or known subtype, application/octet-stream should be used.
    {"TO_DOWNLOAD", CONTENT_TYPE_IANA["APPLICATION"]["octet-stream"]}, // Browsers treat this as if the Content-Disposition header was set to attachment, and propose a "Save As" dialog.
  };

  //#region WEB
  public static readonly string CSS = CONTENT_TYPE_IANA["TEXT"]["css"];   // CSS files used to style a Web page must be sent with text/css.
  public static readonly string CSV = CONTENT_TYPE_IANA["TEXT"]["csv"];
  public static readonly string HTML = CONTENT_TYPE_IANA["TEXT"]["html"];
  public static readonly string JS = CONTENT_TYPE_IANA["TEXT"]["javascript"];
  public static readonly string JSON = CONTENT_TYPE_IANA["APPLICATION"]["json"];
  public static readonly string JSONLD = CONTENT_TYPE_IANA["APPLICATION"]["ld+json"];   // JSON-LD format
  public static readonly string MJS = CONTENT_TYPE_IANA["TEXT"]["javascript"];   // JavaScript module
  public static readonly string PHP = "application/x-httpd-php";   // Hypertext Preprocessor (Personal Home Page)
  public static readonly string WEB_MANIFEST = CONTENT_TYPE_IANA["APPLICATION"]["manifest+json"];   // Web application manifest
  public static readonly string XHTML = CONTENT_TYPE_IANA["APPLICATION"]["xhtml+xml"];

  public static readonly string ANY_APPLICATION = "application/*";
  //#endregion

  //#region COMPRESSED
  public static readonly string _7Z = "application/x-7z-compressed";
  public static readonly string ARC = "application/x-freearc";   //Archive document (multiple files embedded)
  public static readonly string BZ = "application/x-bzip";   // BZip archive
  public static readonly string BZ2 = "application/x-bzip2";   // BZip2 archive
  public static readonly string GZ = CONTENT_TYPE_IANA["APPLICATION"]["gzip"];   // GZip Compressed Archive
  public static readonly string GZ_ALT = "application/x-gzip";
  public static readonly string JAR = CONTENT_TYPE_IANA["APPLICATION"]["java-archive"]; // Java Archive (JAR)
  public static readonly string MPKG = CONTENT_TYPE_IANA["APPLICATION"]["vnd.apple.installer+xml"];   // Apple Installer Package
  public static readonly string RAR = CONTENT_TYPE_IANA["APPLICATION"]["vnd.rar"];
  public static readonly string RAR_ALT = "application/x-rar-compressed";
  public static readonly string TAR = "application/x-tar";   // Tape Archive (TAR)
  public static readonly string ZIP = CONTENT_TYPE_IANA["APPLICATION"]["zip"];
  public static readonly string ZIP_ALT = "application/x-zip-compressed";
  //#endregion

  //#region DOCUMENTS
  public static readonly string ABW = "application/x-abiword";   // AbiWord document
  public static readonly string AZW = "application/vnd.amazon.ebook";    // Amazon Kindle eBook format
  public static readonly string DOC = CONTENT_TYPE_IANA["APPLICATION"]["msword"];
  public static readonly string DOCX = CONTENT_TYPE_IANA["APPLICATION"]["vnd.openxmlformats-officedocument.wordprocessingml.document"];
  public static readonly string EPUB = CONTENT_TYPE_IANA["APPLICATION"]["epub+zip"];    // Electronic publication (EPUB)
  public static readonly string ICS = "text/calendar";   // iCalendar format
  public static readonly string MD = CONTENT_TYPE_IANA["TEXT"]["markdown"];
  public static readonly string ODP = CONTENT_TYPE_IANA["APPLICATION"]["vnd.oasis.opendocument.presentation"];    // OpenDocument presentation document
  public static readonly string ODS = CONTENT_TYPE_IANA["APPLICATION"]["vnd.oasis.opendocument.spreadsheet"];    // OpenDocument spreadsheet document
  public static readonly string ODT = CONTENT_TYPE_IANA["APPLICATION"]["vnd.oasis.opendocument.text"];    // OpenDocument text document
  public static readonly string PDF = CONTENT_TYPE_IANA["APPLICATION"]["pdf"];
  public static readonly string PPT = CONTENT_TYPE_IANA["APPLICATION"]["vnd.ms-powerpoint"];
  public static readonly string PPTX = CONTENT_TYPE_IANA["APPLICATION"]["vnd.openxmlformats-officedocument.presentationml.presentation"];
  public static readonly string RTF = CONTENT_TYPE_IANA["APPLICATION"]["rtf"];
  public static readonly string VSD = CONTENT_TYPE_IANA["APPLICATION"]["vnd.visio"];
  public static readonly string XLS = CONTENT_TYPE_IANA["APPLICATION"]["vnd.ms-excel"];
  public static readonly string XLSX = CONTENT_TYPE_IANA["APPLICATION"]["vnd.openxmlformats-officedocument.spreadsheetml.sheet"];
  public static readonly string XML = CONTENT_TYPE_IANA["APPLICATION"]["xml"];
  public static readonly string XML_ALT = CONTENT_TYPE_IANA["TEXT"]["xml"];
  public static readonly string XML_ATOM = CONTENT_TYPE_IANA["APPLICATION"]["atom+xml"];

  public static readonly string ANY_TEXT = "text/*";
  //#endregion

  //#region IMAGE
  public static readonly string APNG = CONTENT_TYPE_IANA["IMAGE"]["apng"];   // Animated Portable Network Graphics
  public static readonly string AVIF = CONTENT_TYPE_IANA["IMAGE"]["avif"];
  public static readonly string BMP = CONTENT_TYPE_IANA["IMAGE"]["bmp"];
  public static readonly string GIF = CONTENT_TYPE_IANA["IMAGE"]["gif"];   // Graphics Interchange Format (GIF)
  public static readonly string ICON = CONTENT_TYPE_IANA["IMAGE"]["vnd.microsoft.icon"];
  public static readonly string JPEG = CONTENT_TYPE_IANA["IMAGE"]["jpeg"];
  public static readonly string JPG = CONTENT_TYPE_IANA["IMAGE"]["jpeg"];
  public static readonly string PNG = CONTENT_TYPE_IANA["IMAGE"]["png"];
  public static readonly string SVG = CONTENT_TYPE_IANA["IMAGE"]["svg+xml"];    // Scalable Vector Graphics (SVG)
  public static readonly string TIFF = CONTENT_TYPE_IANA["IMAGE"]["tiff"];   // Tagged Image File Format (TIFF)
  public static readonly string WEBP = CONTENT_TYPE_IANA["IMAGE"]["webp"];

  public static readonly string ANY_IMAGE = "image/*";
  //#endregion

  //#region AUDIO
  public static readonly string _3G2_AUDIO = CONTENT_TYPE_IANA["AUDIO"]["3gpp2"];
  public static readonly string _3GP_AUDIO = CONTENT_TYPE_IANA["AUDIO"]["3gpp"];
  public static readonly string AAC = CONTENT_TYPE_IANA["AUDIO"]["aac"];
  public static readonly string MP3 = CONTENT_TYPE_IANA["AUDIO"]["mpeg"];
  public static readonly string CDA = "application/x-cdf";   // CD audio
  public static readonly string MIDI = "audio/x-midi";   // Musical Instrument Digital Interface (MIDI)
  public static readonly string MIDI_ALT = "audio/midi";
  public static readonly string OGA = CONTENT_TYPE_IANA["AUDIO"]["ogg"];
  public static readonly string OPUS = CONTENT_TYPE_IANA["AUDIO"]["ogg"];
  public static readonly string WAV = "audio/wav";   // Waveform Audio Format
  public static readonly string WEBA = "audio/webm";

  public static readonly string ANY_AUDIO = "audio/*";
  //#endregion

  //#region VIDEO
  public static readonly string _3G2 = CONTENT_TYPE_IANA["VIDEO"]["3gpp2"];
  public static readonly string _3GP = CONTENT_TYPE_IANA["VIDEO"]["3gpp"];
  public static readonly string AVI = "video/x-msvideo";   //    public static readonly string AVI = Audio Video Interleave
  public static readonly string AVI_ALT = "video/avi";
  public static readonly string MP4 = CONTENT_TYPE_IANA["VIDEO"]["mp4"];
  public static readonly string MPEG = CONTENT_TYPE_IANA["VIDEO"]["mpeg"];
  public static readonly string OGV = CONTENT_TYPE_IANA["VIDEO"]["ogg"];
  public static readonly string TS = CONTENT_TYPE_IANA["VIDEO"]["MP2T"];     // MPEG transport stream
  public static readonly string WEBM = "video/webm";

  public static readonly string ANY_VIDEO = "video/*";
  //#endregion

  //#region FONT
  public static readonly string EOT = CONTENT_TYPE_IANA["APPLICATION"]["vnd.ms-fontobject"];   // MS Embedded OpenType fonts
  public static readonly string OTF = CONTENT_TYPE_IANA["FONT"]["otf"];
  public static readonly string TTF = CONTENT_TYPE_IANA["FONT"]["ttf"];    // TrueType Font
  public static readonly string WOFF = CONTENT_TYPE_IANA["FONT"]["woff"];   // Web Open Font Format (WOFF)
  public static readonly string WOFF2 = CONTENT_TYPE_IANA["FONT"]["woff2"];

  public static readonly string ANY_FONT = "font/*";
	//#endregion
    
	//#region OTHERS
  public static readonly string CSH = "application/x-csh";   // C-Shell script
  public static readonly string SH = "application/x-sh";   // Bourne shell script
	//#endregion

  public static readonly string FORM_URLENCODED = CONTENT_TYPE_IANA["APPLICATION"]["x-www-form-urlencoded"];
  public static readonly string FORM_DATA = CONTENT_TYPE_IANA["MULTIPART"]["form-data"];

  public static readonly string ANY = "*/*";
  public static readonly string TEXT = CONTENT_TYPE_IANA["TEXT"]["plain"];    // For text documents without a specific subtype, text/plain should be used.
  public static readonly string BINARY = CONTENT_TYPE_IANA["APPLICATION"]["octet-stream"]; // Any kind of binary data.
  public static readonly string UNRECOGNIZED = CONTENT_TYPE_IANA["APPLICATION"]["octet-stream"]; // For binary documents without a specific or known subtype, application/octet-stream should be used.
  public static readonly string TO_DOWNLOAD = CONTENT_TYPE_IANA["APPLICATION"]["octet-stream"]; // Browsers treat this as if the Content-Disposition header was set to attachment, and propose a "Save As" dialog.
}

public enum WebApiContentTypeEnum
{
//#region WEB
  CSS,   // CSS files used to style a Web page must be sent with text/css.
  CSV,
  HTML,
  JS,
  JSON,
  JSONLD,   // JSON-LD format
  MJS,   // JavaScript module
  PHP,   // Hypertext Preprocessor (Personal Home Page)
  WEB_MANIFEST,   // Web application manifest
  XHTML,

  ANY_APPLICATION,
  //#endregion

  //#region COMPRESSED
  _7Z,
  ARC,   //Archive document (multiple files embedded)
  BZ,   // BZip archive
  BZ2,   // BZip2 archive
  GZ,   // GZip Compressed Archive
  GZ_ALT,
  JAR, // Java Archive (JAR)
  MPKG,   // Apple Installer Package
  RAR,
  RAR_ALT, 
  TAR,   // Tape Archive (TAR)
  ZIP,
  ZIP_ALT,
  //#endregion
  
  //#region DOCUMENTS
  ABW,   // AbiWord document
  AZW,    // Amazon Kindle eBook format
  DOC,
  DOCX,
  EPUB,    // Electronic publication (EPUB)
  ICS,   // iCalendar format
  MD,
  ODP,    // OpenDocument presentation document
  ODS,    // OpenDocument spreadsheet document
  ODT,    // OpenDocument text document
  PDF,
  PPT,
  PPTX,
  RTF,
  VSD,
  XLS,
  XLSX,
  XML,
  XML_ALT,
  XML_ATOM,

  ANY_TEXT,
  //#endregion
  
  //#region IMAGE
  APNG,   // Animated Portable Network Graphics
  AVIF,
  BMP,
  GIF,   // Graphics Interchange Format (GIF)
  ICON,
  JPEG,
  JPG,
  PNG,
  SVG,    // Scalable Vector Graphics (SVG)
  TIFF,   // Tagged Image File Format (TIFF)
  WEBP,

  ANY_IMAGE,
  //#endregion

  //#region AUDIO
  _3G2_AUDIO,
  _3GP_AUDIO,
  AAC,
  MP3,
  CDA,   // CD audio
  MIDI,   // Musical Instrument Digital Interface (MIDI)
  MIDI_ALT,
  OGA,
  OPUS,
  WAV,   // Waveform Audio Format
  WEBA,

  ANY_AUDIO,
  //#endregion
  
  //#region VIDEO
  _3G2,
  _3GP,
  AVI,   // AVI: Audio Video Interleave
  AVI_ALT,
  MP4,
  MPEG,
  OGV,
  TS,     // MPEG transport stream
  WEBM,
  
  ANY_VIDEO,
  //#endregion
  
  //#region FONT
  EOT,   // MS Embedded OpenType fonts
  OTF,
  TTF,    // TrueType Font
  WOFF,   // Web Open Font Format (WOFF)
  WOFF2,
  
  ANY_FONT,
  //#endregion
    
  //#region OTHERS
  CSH,   // C-Shell script
  SH,   // Bourne shell script
  //#endregion

  FORM_URLENCODED,
  FORM_DATA,
  
  ANY,
  TEXT,    // For text documents without a specific subtype, text/plain should be used.
  BINARY, // Any kind of binary data.
  UNRECOGNIZED, // For binary documents without a specific or known subtype, application/octet-stream should be used.
  TO_DOWNLOAD, // Browsers treat this as if the Content-Disposition header was set to attachment, and propose a "Save As" dialog.
}

public static class WebApiContentTypeEnumExtension
{
  public static string ToStringContentType(this WebApiContentTypeEnum wact)
  {
    return Type.GetType("WebApiContentType")?.GetField(wact.ToString())?.GetValue(null)?.ToString() ?? "";
  }
}