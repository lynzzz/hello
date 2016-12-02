' NX 10.0.3.5
' Journal created by uwhfz3 on Fri Jul 01 09:45:28 2016 Central Daylight Time
'
Option Strict Off
Imports System
Imports NXOpen

Module NXJournal
Sub Main (ByVal args() As String) 

Dim theSession As NXOpen.Session = NXOpen.Session.GetSession()
Dim markId1 As NXOpen.Session.UndoMarkId
markId1 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Load Part")

Dim basePart1 As NXOpen.BasePart
Dim partLoadStatus1 As NXOpen.PartLoadStatus
basePart1 = theSession.Parts.OpenBaseDisplay("C:\Users\uwhfz3\Desktop\ROU1044_Port_Offset_Enhancement_Path_Arrangement\Path_Arrangement\Path_Arrange.prt", partLoadStatus1)

Dim workPart As NXOpen.Part = theSession.Parts.Work

Dim displayPart As NXOpen.Part = theSession.Parts.Display

partLoadStatus1.Dispose()
Dim markId2 As NXOpen.Session.UndoMarkId
markId2 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Enter Gateway")

theSession.Preferences.RoutingApplicationView.LoadAppView("D:\workdir\refunits\nx1003.5\wntx64\kits\ugroute_elec\appview\ugroute_elec_metric.xml")

theSession.Preferences.RoutingApplicationView.ApplicationType = NXOpen.Preferences.RoutingApplicationView.AppType.Electrical

' ----------------------------------------------
'   Menu: Edit->Routing Path->Path Arrangement...
' ----------------------------------------------
Dim markId3 As NXOpen.Session.UndoMarkId
markId3 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Select Assembly")

theSession.DeleteUndoMark(markId3, Nothing)

Dim markId4 As NXOpen.Session.UndoMarkId
markId4 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "Open Component Fully")

Dim markId5 As NXOpen.Session.UndoMarkId
markId5 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "Open Component")

Dim option1 As Boolean
option1 = theSession.Parts.LoadOptions.UsePartialLoading

theSession.Parts.LoadOptions.UsePartialLoading = False

Dim componentsToOpen1(18) As NXOpen.Assemblies.Component
Dim component1 As NXOpen.Assemblies.Component = CType(workPart.ComponentAssembly.RootComponent.FindObject("COMPONENT Harnesses 1"), NXOpen.Assemblies.Component)

Dim component2 As NXOpen.Assemblies.Component = CType(component1.FindObject("COMPONENT H3 1"), NXOpen.Assemblies.Component)

componentsToOpen1(0) = component2
Dim component3 As NXOpen.Assemblies.Component = CType(component1.FindObject("COMPONENT H4 1"), NXOpen.Assemblies.Component)

Dim component4 As NXOpen.Assemblies.Component = CType(component3.FindObject("COMPONENT 4_pin_green_square_mm 2"), NXOpen.Assemblies.Component)

componentsToOpen1(1) = component4
Dim component5 As NXOpen.Assemblies.Component = CType(workPart.ComponentAssembly.RootComponent.FindObject("COMPONENT Hardware 1"), NXOpen.Assemblies.Component)

Dim component6 As NXOpen.Assemblies.Component = CType(component5.FindObject("COMPONENT clamp_w_hole_1 1"), NXOpen.Assemblies.Component)

componentsToOpen1(2) = component6
componentsToOpen1(3) = workPart.ComponentAssembly.RootComponent
componentsToOpen1(4) = component5
Dim component7 As NXOpen.Assemblies.Component = CType(component2.FindObject("COMPONENT 4_pin_green_square_mm 1"), NXOpen.Assemblies.Component)

componentsToOpen1(5) = component7
componentsToOpen1(6) = component3
Dim component8 As NXOpen.Assemblies.Component = CType(component1.FindObject("COMPONENT H2 1"), NXOpen.Assemblies.Component)

componentsToOpen1(7) = component8
Dim component9 As NXOpen.Assemblies.Component = CType(component1.FindObject("COMPONENT H1 1"), NXOpen.Assemblies.Component)

Dim component10 As NXOpen.Assemblies.Component = CType(component9.FindObject("COMPONENT 4_pin_green_square_mm 1"), NXOpen.Assemblies.Component)

componentsToOpen1(8) = component10
Dim component11 As NXOpen.Assemblies.Component = CType(component5.FindObject("COMPONENT Clamp 1"), NXOpen.Assemblies.Component)

componentsToOpen1(9) = component11
Dim component12 As NXOpen.Assemblies.Component = CType(component9.FindObject("COMPONENT 4_pin_green_square_mm 2"), NXOpen.Assemblies.Component)

componentsToOpen1(10) = component12
Dim component13 As NXOpen.Assemblies.Component = CType(component8.FindObject("COMPONENT 4_pin_green_square_mm 2"), NXOpen.Assemblies.Component)

componentsToOpen1(11) = component13
componentsToOpen1(12) = component1
componentsToOpen1(13) = component9
Dim component14 As NXOpen.Assemblies.Component = CType(component5.FindObject("COMPONENT clamp_w_hole_2 1"), NXOpen.Assemblies.Component)

componentsToOpen1(14) = component14
Dim component15 As NXOpen.Assemblies.Component = CType(component2.FindObject("COMPONENT 4_pin_green_square_mm 3"), NXOpen.Assemblies.Component)

componentsToOpen1(15) = component15
Dim component16 As NXOpen.Assemblies.Component = CType(component3.FindObject("COMPONENT 4_pin_green_square_mm 1"), NXOpen.Assemblies.Component)

componentsToOpen1(16) = component16
Dim component17 As NXOpen.Assemblies.Component = CType(component8.FindObject("COMPONENT 4_pin_green_square_mm 1"), NXOpen.Assemblies.Component)

componentsToOpen1(17) = component17
Dim component18 As NXOpen.Assemblies.Component = CType(component2.FindObject("COMPONENT 4_pin_green_square_mm 2"), NXOpen.Assemblies.Component)

componentsToOpen1(18) = component18
Dim option2 As Boolean
option2 = theSession.Parts.LoadOptions.UsePartialLoading

Dim openStatus1() As NXOpen.Assemblies.ComponentAssembly.OpenComponentStatus
Dim partLoadStatus2 As NXOpen.PartLoadStatus
partLoadStatus2 = workPart.ComponentAssembly.OpenComponents(NXOpen.Assemblies.ComponentAssembly.OpenOption.ComponentOnly, componentsToOpen1, openStatus1)

theSession.Parts.LoadOptions.UsePartialLoading = True

partLoadStatus2.Dispose()
theSession.DeleteUndoMark(markId4, Nothing)

' ----------------------------------------------
'   Menu: Edit->Routing Path->Path Arrangement...
' ----------------------------------------------
Dim markId6 As NXOpen.Session.UndoMarkId
markId6 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "'Start")

Dim pathArrangementBuilder1 As NXOpen.Routing.PathArrangementBuilder
pathArrangementBuilder1 = workPart.RouteManager.CreatePathArrangementBuilder()

theSession.SetUndoMarkName(markId6, "''Arrange Paths Dialog")

Dim markId7 As NXOpen.Session.UndoMarkId
markId7 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "'Arrange Paths")

theSession.DeleteUndoMark(markId7, Nothing)

Dim markId8 As NXOpen.Session.UndoMarkId
markId8 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "'Arrange Paths")

pathArrangementBuilder1.ClearHarnessData()

Dim part1 As NXOpen.Part = CType(theSession.Parts.FindObject("clamp_w_hole_1"), NXOpen.Part)

Dim fixturePort1 As NXOpen.Routing.FixturePort = CType(part1.FindObject("HANDLE R-21659"), NXOpen.Routing.FixturePort)

pathArrangementBuilder1.PrototypePort = fixturePort1

pathArrangementBuilder1.PrototypePortPartOccurrence = component6

pathArrangementBuilder1.ClearHarnessData()

theSession.Parts.SetWork(workPart)

workPart = theSession.Parts.Work
theSession.SetUndoMarkName(markId8, "'Arrange Paths - 'Selection")

theSession.SetUndoMarkVisibility(markId8, Nothing, NXOpen.Session.MarkVisibility.Visible)

theSession.SetUndoMarkVisibility(markId6, Nothing, NXOpen.Session.MarkVisibility.Invisible)

Dim markId9 As NXOpen.Session.UndoMarkId
markId9 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "'Arrange Paths")

theSession.DeleteUndoMark(markId9, Nothing)

Dim markId10 As NXOpen.Session.UndoMarkId
markId10 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "'Arrange Paths")

Dim part2 As NXOpen.Part = CType(theSession.Parts.FindObject("H1"), NXOpen.Part)

Dim extractPort1 As NXOpen.Routing.ExtractPort = CType(part2.FindObject("HANDLE R-874"), NXOpen.Routing.ExtractPort)

pathArrangementBuilder1.ReferencePort = extractPort1

pathArrangementBuilder1.HarnessPartOccurrence = component9

Dim partLoadStatus3 As NXOpen.PartLoadStatus
theSession.Parts.SetWorkComponent(component9, partLoadStatus3)

workPart = theSession.Parts.Work
partLoadStatus3.Dispose()
pathArrangementBuilder1.EstablishPathArrangement()

theSession.SetUndoMarkName(markId10, "'Arrange Paths")

theSession.SetUndoMarkVisibility(markId10, Nothing, NXOpen.Session.MarkVisibility.Visible)

theSession.SetUndoMarkVisibility(markId6, Nothing, NXOpen.Session.MarkVisibility.Invisible)

Dim markId11 As NXOpen.Session.UndoMarkId
markId11 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "'Arrange Paths")

theSession.DeleteUndoMark(markId11, Nothing)

Dim markId12 As NXOpen.Session.UndoMarkId
markId12 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "'Arrange Paths")

theSession.DeleteUndoMark(markId12, Nothing)

Dim markId13 As NXOpen.Session.UndoMarkId
markId13 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "'Arrange Paths")

Dim point1 As NXOpen.Point3d = New NXOpen.Point3d(-2.14022526873193, -1.83415481423913, -0.23124515031762)
pathArrangementBuilder1.SetPathArrangementOrigin(point1)

theSession.SetUndoMarkName(markId13, "'Arrange Paths - 'Manipulator")

theSession.SetUndoMarkVisibility(markId13, Nothing, NXOpen.Session.MarkVisibility.Visible)

theSession.SetUndoMarkVisibility(markId6, Nothing, NXOpen.Session.MarkVisibility.Invisible)

Dim markId14 As NXOpen.Session.UndoMarkId
markId14 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "'Arrange Paths")

theSession.DeleteUndoMark(markId14, Nothing)

Dim markId15 As NXOpen.Session.UndoMarkId
markId15 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "'Arrange Paths")

theSession.DeleteUndoMark(markId15, Nothing)

Dim markId16 As NXOpen.Session.UndoMarkId
markId16 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "'Arrange Paths")

Dim markId17 As NXOpen.Session.UndoMarkId
markId17 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "'Arrange Paths")

theSession.DeleteUndoMark(markId17, Nothing)

Dim markId18 As NXOpen.Session.UndoMarkId
markId18 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "'Arrange Paths")

theSession.DeleteUndoMark(markId18, Nothing)

theSession.SetUndoMarkName(markId6, "'Arrange Paths")

theSession.Parts.SetWork(displayPart)

workPart = theSession.Parts.Work
Dim nullNXOpen_Assemblies_Component As NXOpen.Assemblies.Component = Nothing

pathArrangementBuilder1.HarnessPartOccurrence = nullNXOpen_Assemblies_Component

pathArrangementBuilder1.Destroy()

theSession.SetUndoMarkVisibility(markId6, Nothing, NXOpen.Session.MarkVisibility.Visible)

theSession.DeleteUndoMark(markId13, Nothing)

theSession.DeleteUndoMark(markId10, Nothing)

theSession.DeleteUndoMark(markId8, Nothing)

Dim rotMatrix1 As NXOpen.Matrix3x3
rotMatrix1.Xx = 0.992116866884848
rotMatrix1.Xy = 0.125082816397137
rotMatrix1.Xz = -0.00764274065716895
rotMatrix1.Yx = -0.012939159296885
rotMatrix1.Yy = 0.162909278708848
rotMatrix1.Yz = 0.986556204717832
rotMatrix1.Zx = 0.124646301987995
rotMatrix1.Zy = -0.978680160191634
rotMatrix1.Zz = 0.163243509665758
Dim translation1 As NXOpen.Point3d = New NXOpen.Point3d(-1.51159341286692, -4.23426230116296, -1.38157063395319)
workPart.ModelingViews.WorkView.SetRotationTranslationScale(rotMatrix1, translation1, 3.31088024526524)

Dim scaleAboutPoint1 As NXOpen.Point3d = New NXOpen.Point3d(-0.0959588719005093, -0.372823813777388, 0.0)
Dim viewCenter1 As NXOpen.Point3d = New NXOpen.Point3d(0.0959588719005093, 0.372823813777388, 0.0)
workPart.ModelingViews.WorkView.ZoomAboutPoint(0.8, scaleAboutPoint1, viewCenter1)

Dim scaleAboutPoint2 As NXOpen.Point3d = New NXOpen.Point3d(-0.18680518095386, -0.422769620053472, 0.0)
Dim viewCenter2 As NXOpen.Point3d = New NXOpen.Point3d(0.186805180953861, 0.422769620053472, 0.0)
workPart.ModelingViews.WorkView.ZoomAboutPoint(0.8, scaleAboutPoint2, viewCenter2)

Dim scaleAboutPoint3 As NXOpen.Point3d = New NXOpen.Point3d(-0.233506476192325, -0.528462025066841, 0.0)
Dim viewCenter3 As NXOpen.Point3d = New NXOpen.Point3d(0.233506476192326, 0.52846202506684, 0.0)
workPart.ModelingViews.WorkView.ZoomAboutPoint(0.8, scaleAboutPoint3, viewCenter3)

Dim scaleAboutPoint4 As NXOpen.Point3d = New NXOpen.Point3d(-0.291883095240406, -0.66057753133355, 0.0)
Dim viewCenter4 As NXOpen.Point3d = New NXOpen.Point3d(0.291883095240407, 0.66057753133355, 0.0)
workPart.ModelingViews.WorkView.ZoomAboutPoint(0.8, scaleAboutPoint4, viewCenter4)

Dim scaleAboutPoint5 As NXOpen.Point3d = New NXOpen.Point3d(-0.364853869050508, -0.825721914166939, 0.0)
Dim viewCenter5 As NXOpen.Point3d = New NXOpen.Point3d(0.364853869050508, 0.825721914166938, 0.0)
workPart.ModelingViews.WorkView.ZoomAboutPoint(0.8, scaleAboutPoint5, viewCenter5)

Dim scaleAboutPoint6 As NXOpen.Point3d = New NXOpen.Point3d(-0.43686450109995, -1.03215239270867, 0.0)
Dim viewCenter6 As NXOpen.Point3d = New NXOpen.Point3d(0.43686450109995, 1.03215239270867, 0.0)
workPart.ModelingViews.WorkView.ZoomAboutPoint(0.8, scaleAboutPoint6, viewCenter6)

Dim scaleAboutPoint7 As NXOpen.Point3d = New NXOpen.Point3d(-0.534078854366697, -1.29019049088584, 0.0)
Dim viewCenter7 As NXOpen.Point3d = New NXOpen.Point3d(0.534078854366695, 1.29019049088584, 0.0)
workPart.ModelingViews.WorkView.ZoomAboutPoint(0.8, scaleAboutPoint7, viewCenter7)

Dim scaleAboutPoint8 As NXOpen.Point3d = New NXOpen.Point3d(-0.637594137937772, -1.6277403286176, 0.0)
Dim viewCenter8 As NXOpen.Point3d = New NXOpen.Point3d(0.637594137937768, 1.6277403286176, 0.0)
workPart.ModelingViews.WorkView.ZoomAboutPoint(0.8, scaleAboutPoint8, viewCenter8)

Dim scaleAboutPoint9 As NXOpen.Point3d = New NXOpen.Point3d(-1.0407786663396, -2.25970863592651, 0.0)
Dim viewCenter9 As NXOpen.Point3d = New NXOpen.Point3d(1.04077866633959, 2.25970863592651, 0.0)
workPart.ModelingViews.WorkView.ZoomAboutPoint(0.8, scaleAboutPoint9, viewCenter9)

Dim scaleAboutPoint10 As NXOpen.Point3d = New NXOpen.Point3d(-1.32441429387809, -2.91839963872252, 0.0)
Dim viewCenter10 As NXOpen.Point3d = New NXOpen.Point3d(1.32441429387808, 2.91839963872251, 0.0)
workPart.ModelingViews.WorkView.ZoomAboutPoint(0.8, scaleAboutPoint10, viewCenter10)

' ----------------------------------------------
'   Menu: Edit->Routing Path->Path Arrangement...
' ----------------------------------------------
Dim markId19 As NXOpen.Session.UndoMarkId
markId19 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Visible, "'Start")

Dim pathArrangementBuilder2 As NXOpen.Routing.PathArrangementBuilder
pathArrangementBuilder2 = workPart.RouteManager.CreatePathArrangementBuilder()

theSession.SetUndoMarkName(markId19, "''Arrange Paths Dialog")

Dim markId20 As NXOpen.Session.UndoMarkId
markId20 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "'Arrange Paths")

theSession.DeleteUndoMark(markId20, Nothing)

Dim markId21 As NXOpen.Session.UndoMarkId
markId21 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "'Arrange Paths")

pathArrangementBuilder2.ClearHarnessData()

Dim part3 As NXOpen.Part = CType(theSession.Parts.FindObject("clamp_w_hole_2"), NXOpen.Part)

Dim fixturePort2 As NXOpen.Routing.FixturePort = CType(part3.FindObject("HANDLE R-21659"), NXOpen.Routing.FixturePort)

pathArrangementBuilder2.PrototypePort = fixturePort2

pathArrangementBuilder2.PrototypePortPartOccurrence = component14

pathArrangementBuilder2.ClearHarnessData()

theSession.Parts.SetWork(workPart)

workPart = theSession.Parts.Work
theSession.SetUndoMarkName(markId21, "'Arrange Paths - 'Selection")

theSession.SetUndoMarkVisibility(markId21, Nothing, NXOpen.Session.MarkVisibility.Visible)

theSession.SetUndoMarkVisibility(markId19, Nothing, NXOpen.Session.MarkVisibility.Invisible)

Dim markId22 As NXOpen.Session.UndoMarkId
markId22 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "'Arrange Paths")

theSession.DeleteUndoMark(markId22, Nothing)

Dim markId23 As NXOpen.Session.UndoMarkId
markId23 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "'Arrange Paths")

Dim extractPort2 As NXOpen.Routing.ExtractPort = CType(part2.FindObject("HANDLE R-868"), NXOpen.Routing.ExtractPort)

pathArrangementBuilder2.ReferencePort = extractPort2

pathArrangementBuilder2.HarnessPartOccurrence = component9

Dim partLoadStatus4 As NXOpen.PartLoadStatus
theSession.Parts.SetWorkComponent(component9, partLoadStatus4)

workPart = theSession.Parts.Work
partLoadStatus4.Dispose()
pathArrangementBuilder2.EstablishPathArrangement()

theSession.SetUndoMarkName(markId23, "'Arrange Paths")

theSession.SetUndoMarkVisibility(markId23, Nothing, NXOpen.Session.MarkVisibility.Visible)

theSession.SetUndoMarkVisibility(markId19, Nothing, NXOpen.Session.MarkVisibility.Invisible)

Dim markId24 As NXOpen.Session.UndoMarkId
markId24 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "'Arrange Paths")

theSession.DeleteUndoMark(markId24, Nothing)

Dim markId25 As NXOpen.Session.UndoMarkId
markId25 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "'Arrange Paths")

theSession.DeleteUndoMark(markId25, Nothing)

Dim markId26 As NXOpen.Session.UndoMarkId
markId26 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "'Arrange Paths")

Dim point2 As NXOpen.Point3d = New NXOpen.Point3d(-3.54145543052402, 15.8540647641084, -0.613048368953882)
pathArrangementBuilder2.SetPathArrangementOrigin(point2)

theSession.SetUndoMarkName(markId26, "'Arrange Paths - 'Manipulator")

theSession.SetUndoMarkVisibility(markId26, Nothing, NXOpen.Session.MarkVisibility.Visible)

theSession.SetUndoMarkVisibility(markId19, Nothing, NXOpen.Session.MarkVisibility.Invisible)

Dim markId27 As NXOpen.Session.UndoMarkId
markId27 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "'Arrange Paths")

theSession.DeleteUndoMark(markId27, Nothing)

Dim markId28 As NXOpen.Session.UndoMarkId
markId28 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "'Arrange Paths")

theSession.DeleteUndoMark(markId28, Nothing)

Dim markId29 As NXOpen.Session.UndoMarkId
markId29 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "'Arrange Paths")

Dim markId30 As NXOpen.Session.UndoMarkId
markId30 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "'Arrange Paths")

theSession.DeleteUndoMark(markId30, Nothing)

Dim markId31 As NXOpen.Session.UndoMarkId
markId31 = theSession.SetUndoMark(NXOpen.Session.MarkVisibility.Invisible, "'Arrange Paths")

theSession.DeleteUndoMark(markId31, Nothing)

theSession.SetUndoMarkName(markId19, "'Arrange Paths")

theSession.Parts.SetWork(displayPart)

workPart = theSession.Parts.Work
pathArrangementBuilder2.HarnessPartOccurrence = nullNXOpen_Assemblies_Component

pathArrangementBuilder2.Destroy()

theSession.SetUndoMarkVisibility(markId19, Nothing, NXOpen.Session.MarkVisibility.Visible)

theSession.DeleteUndoMark(markId26, Nothing)

theSession.DeleteUndoMark(markId23, Nothing)

theSession.DeleteUndoMark(markId21, Nothing)

' ----------------------------------------------
'   Menu: Tools->Journal->Stop Recording
' ----------------------------------------------

End Sub
End Module