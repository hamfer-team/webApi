namespace Hamfer.WebApi.Core.ContentTypes;

// Model data for a 3D object or scene.
// https://www.iana.org/assignments/media-types/media-types.xhtml#model
// To use csv: ^([^,]+),(model/[a-z0-9+-_]+),(.+)$	=>	\t"$1": "$2",\t\t// '$1' from reference $3
// last updated as 2025-12-25
public static class ModelContentType
{
	public static readonly Dictionary<string, string> ContentTypes = new()
	{
    {"3mf", "model/3mf"},		// '3mf' from reference [http://www.3mf.io/specification][_3MF][Michael_Sweet]
    {"e57", "model/e57"},		// 'e57' from reference [ASTM]
    {"example", "model/example"},		// 'example' from reference [RFC4735]
    {"gltf-binary", "model/gltf-binary"},		// 'gltf-binary' from reference [Khronos][Saurabh_Bhatia]
    {"gltf+json", "model/gltf+json"},		// 'gltf+json' from reference [Khronos][Uli_Klumpp]
    {"JT", "model/JT"},		// 'JT' from reference [ISO-TC_184-SC_4][Michael_Zink]
    {"iges", "model/iges"},		// 'iges' from reference [Curtis_Parks]
    {"mesh", "model/mesh"},		// 'mesh' from reference [RFC2077]
    {"mtl", "model/mtl"},		// 'mtl' from reference [DICOM_Standard_Committee][DICOM_WG_17][Carolyn_Hull]
    {"obj", "model/obj"},		// 'obj' from reference [DICOM_Standard_Committee][DICOM_WG_17][Carolyn_Hull]
    {"prc", "model/prc"},		// 'prc' from reference [ISO-TC_171-SC_2][Betsy_Fanning]
    {"step", "model/step"},		// 'step' from reference [ISO-TC_184-SC_4][Dana_Tripp]
    {"step+xml", "model/step+xml"},		// 'step+xml' from reference [ISO-TC_184-SC_4][Dana_Tripp]
    {"step+zip", "model/step+zip"},		// 'step+zip' from reference [ISO-TC_184-SC_4][Dana_Tripp]
    {"step-xml+zip", "model/step-xml+zip"},		// 'step-xml+zip' from reference [ISO-TC_184-SC_4][Dana_Tripp]
    {"stl", "model/stl"},		// 'stl' from reference [DICOM_Standard_Committee][DICOM_WG_17][Carolyn_Hull]
    {"u3d", "model/u3d"},		// 'u3d' from reference [PDF_Association][Peter_Wyatt]
    {"vnd.bary", "model/vnd.bary"},		// 'vnd.bary' from reference [Displaced_Micro-Mesh_SDK_Support]
    {"vnd.cld", "model/vnd.cld"},		// 'vnd.cld' from reference [Robert_Monaghan]
    {"vnd.collada+xml", "model/vnd.collada+xml"},		// 'vnd.collada+xml' from reference [James_Riordon]
    {"vnd.dwf", "model/vnd.dwf"},		// 'vnd.dwf' from reference [Jason_Pratt]
    {"vnd.flatland.3dml", "model/vnd.flatland.3dml"},		// 'vnd.flatland.3dml' from reference [Michael_Powers]
    {"vnd.gdl", "model/vnd.gdl"},		// 'vnd.gdl' from reference [Attila_Babits]
    {"vnd.gs-gdl", "model/vnd.gs-gdl"},		// 'vnd.gs-gdl' from reference [Attila_Babits]
    {"vnd.gtw", "model/vnd.gtw"},		// 'vnd.gtw' from reference [Yutaka_Ozaki]
    {"vnd.moml+xml", "model/vnd.moml+xml"},		// 'vnd.moml+xml' from reference [Christopher_Brooks]
    {"vnd.mts", "model/vnd.mts"},		// 'vnd.mts' from reference [Boris_Rabinovitch]
    {"vnd.opengex", "model/vnd.opengex"},		// 'vnd.opengex' from reference [Eric_Lengyel]
    {"vnd.parasolid.transmit.binary", "model/vnd.parasolid.transmit.binary"},		// 'vnd.parasolid.transmit.binary' from reference [Parasolid]
    {"vnd.parasolid.transmit.text", "model/vnd.parasolid.transmit.text"},		// 'vnd.parasolid.transmit.text' from reference [Parasolid]
    {"vnd.pytha.pyox", "model/vnd.pytha.pyox"},		// 'vnd.pytha.pyox' from reference [Daniel_Flassig]
    {"vnd.rosette.annotated-data-model", "model/vnd.rosette.annotated-data-model"},		// 'vnd.rosette.annotated-data-model' from reference [Benson_Margulies]
    {"vnd.sap.vds", "model/vnd.sap.vds"},		// 'vnd.sap.vds' from reference [SAP_SE][Igor_Afanasyev]
    {"vnd.usda", "model/vnd.usda"},		// 'vnd.usda' from reference [Sebastian_Grassia]
    {"vnd.usdz+zip", "model/vnd.usdz+zip"},		// 'vnd.usdz+zip' from reference [Sebastian_Grassia]
    {"vnd.valve.source.compiled-map", "model/vnd.valve.source.compiled-map"},		// 'vnd.valve.source.compiled-map' from reference [Henrik_Andersson]
    {"vnd.vtu", "model/vnd.vtu"},		// 'vnd.vtu' from reference [Boris_Rabinovitch]
    {"vrml", "model/vrml"},		// 'vrml' from reference [RFC2077]
    {"x3d-vrml", "model/x3d-vrml"},		// 'x3d-vrml' from reference [Web3D][Web3D_X3D]
    {"x3d+fastinfoset", "model/x3d+fastinfoset"},		// 'x3d+fastinfoset' from reference [Web3D_X3D]
    {"x3d+xml", "model/x3d+xml"},		// 'x3d+xml' from reference [Web3D][Web3D_X3D]
	};
}