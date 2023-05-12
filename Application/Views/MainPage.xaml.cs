namespace Glossa_App.Views;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	class Drawable: IDrawable
	{
		public void Draw(ICanvas canvas, RectF dirtyrect) {

            // View:     frameView
            // NodeName: Phone
            // NodeType: FRAME
            // NodeId:   3:4
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(255, 255, 255);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-568f, -408f, 360f, 640f, 0f);
            canvas.RestoreState();


            // View:     rectangleView
            // NodeName: image 2
            // NodeType: RECTANGLE
            // NodeId:   105:18
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(-633f, -156f, 488f, 382f, 0f);
            canvas.RestoreState();


            // View:     rectangleView1
            // NodeName: image 1
            // NodeType: RECTANGLE
            // NodeId:   105:15
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(-632f, -417f, 488f, 382f, 0f);
            canvas.RestoreState();


            // View:     rectangleView2
            // NodeName: Navbar
            // NodeType: RECTANGLE
            // NodeId:   3:6
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-568f, 163f, 360f, 69f, 0f);
            canvas.RestoreState();


            // View:     rectangleView3
            // NodeName: Headtext
            // NodeType: RECTANGLE
            // NodeId:   3:19
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(167, 167, 167);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-547f, -331f, 118f, 19f, 0f);
            canvas.RestoreState();


            // View:     textView
            // NodeName: Recently uploaded
            // NodeType: TEXT
            // NodeId:   104:13
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(81, 81, 81);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 14f;
            canvas.DrawString(@"Recently uploaded", -545f, -331f, 150f, 17f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     frameView1
            // NodeName: Test by D
            // NodeType: GROUP
            // NodeId:   3:25
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView4
            // NodeName: Test 2
            // NodeType: RECTANGLE
            // NodeId:   3:24
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-545f, -288f, 314f, 77f, 0f);
            canvas.RestoreState();


            // View:     rectangleView5
            // NodeName: Rectangle 1
            // NodeType: RECTANGLE
            // NodeId:   3:13
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-539.03796f, -282f, 64.58862f, 65f, 0f);
            canvas.RestoreState();


            // View:     rectangleView6
            // NodeName: Rectangle 6
            // NodeType: RECTANGLE
            // NodeId:   3:20
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-457.55695f, -269f, 90.42404f, 12f, 0f);
            canvas.RestoreState();


            // View:     rectangleView7
            // NodeName: Rectangle 7
            // NodeType: RECTANGLE
            // NodeId:   3:21
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(182, 181, 181);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-457.55695f, -248f, 201.7152f, 22f, 0f);
            canvas.RestoreState();


            // View:     rectangleView8
            // NodeName: Rectangle 8
            // NodeType: RECTANGLE
            // NodeId:   3:23
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(223, 223, 223);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-457.55695f, -284f, 31.797455f, 6f, 0f);
            canvas.RestoreState();


            // View:     rectangleView9
            // NodeName: Test 1
            // NodeType: RECTANGLE
            // NodeId:   4:5
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-545f, -275f, 314f, 64f, 0f);
            canvas.RestoreState();


            // View:     frameView2
            // NodeName: Test by D
            // NodeType: GROUP
            // NodeId:   5:25
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView10
            // NodeName: Test 2
            // NodeType: RECTANGLE
            // NodeId:   5:26
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-545f, 114f, 314f, 49f, 0f);
            canvas.RestoreState();


            // View:     rectangleView11
            // NodeName: Rectangle 1
            // NodeType: RECTANGLE
            // NodeId:   5:27
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-539.03796f, 120f, 64.58862f, 43f, 0f);
            canvas.RestoreState();


            // View:     rectangleView12
            // NodeName: Rectangle 6
            // NodeType: RECTANGLE
            // NodeId:   5:28
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-457.55695f, 133f, 90.42404f, 12f, 0f);
            canvas.RestoreState();


            // View:     rectangleView13
            // NodeName: Rectangle 7
            // NodeType: RECTANGLE
            // NodeId:   5:29
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(182, 181, 181);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-457.55695f, 154f, 201.7152f, 9f, 0f);
            canvas.RestoreState();


            // View:     rectangleView14
            // NodeName: Rectangle 8
            // NodeType: RECTANGLE
            // NodeId:   5:30
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(223, 223, 223);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-457.55695f, 118f, 31.797455f, 6f, 0f);
            canvas.RestoreState();


            // View:     rectangleView15
            // NodeName: Test 1
            // NodeType: RECTANGLE
            // NodeId:   5:31
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-545f, 127f, 314f, 36f, 0f);
            canvas.RestoreState();


            // View:     frameView3
            // NodeName: Test by D
            // NodeType: GROUP
            // NodeId:   5:3
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView16
            // NodeName: Test 2
            // NodeType: RECTANGLE
            // NodeId:   5:4
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-545f, -187f, 314f, 77f, 0f);
            canvas.RestoreState();


            // View:     rectangleView17
            // NodeName: Rectangle 1
            // NodeType: RECTANGLE
            // NodeId:   5:5
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-539.03796f, -181f, 64.58862f, 65f, 0f);
            canvas.RestoreState();


            // View:     rectangleView18
            // NodeName: Rectangle 6
            // NodeType: RECTANGLE
            // NodeId:   5:6
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-457.55695f, -168f, 90.42404f, 12f, 0f);
            canvas.RestoreState();


            // View:     rectangleView19
            // NodeName: Rectangle 7
            // NodeType: RECTANGLE
            // NodeId:   5:7
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(182, 181, 181);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-457.55695f, -147f, 201.7152f, 22f, 0f);
            canvas.RestoreState();


            // View:     rectangleView20
            // NodeName: Rectangle 8
            // NodeType: RECTANGLE
            // NodeId:   5:8
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(223, 223, 223);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-457.55695f, -183f, 31.797455f, 6f, 0f);
            canvas.RestoreState();


            // View:     rectangleView21
            // NodeName: Test 1
            // NodeType: RECTANGLE
            // NodeId:   5:9
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-545f, -174f, 314f, 64f, 0f);
            canvas.RestoreState();


            // View:     frameView4
            // NodeName: Test by D
            // NodeType: GROUP
            // NodeId:   5:10
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView22
            // NodeName: Test 2
            // NodeType: RECTANGLE
            // NodeId:   5:11
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-545f, -88f, 314f, 77f, 0f);
            canvas.RestoreState();


            // View:     rectangleView23
            // NodeName: Rectangle 1
            // NodeType: RECTANGLE
            // NodeId:   5:12
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-539.03796f, -82f, 64.58862f, 65f, 0f);
            canvas.RestoreState();


            // View:     rectangleView24
            // NodeName: Rectangle 6
            // NodeType: RECTANGLE
            // NodeId:   5:13
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-457.55695f, -69f, 90.42404f, 12f, 0f);
            canvas.RestoreState();


            // View:     rectangleView25
            // NodeName: Rectangle 7
            // NodeType: RECTANGLE
            // NodeId:   5:14
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(182, 181, 181);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-457.55695f, -48f, 201.7152f, 22f, 0f);
            canvas.RestoreState();


            // View:     rectangleView26
            // NodeName: Rectangle 8
            // NodeType: RECTANGLE
            // NodeId:   5:15
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(223, 223, 223);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-457.55695f, -84f, 31.797455f, 6f, 0f);
            canvas.RestoreState();


            // View:     rectangleView27
            // NodeName: Test 1
            // NodeType: RECTANGLE
            // NodeId:   5:16
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-545f, -75f, 314f, 64f, 0f);
            canvas.RestoreState();


            // View:     frameView5
            // NodeName: Test by D
            // NodeType: GROUP
            // NodeId:   5:17
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView28
            // NodeName: Test 2
            // NodeType: RECTANGLE
            // NodeId:   5:18
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-545f, 13f, 314f, 77f, 0f);
            canvas.RestoreState();


            // View:     rectangleView29
            // NodeName: Rectangle 1
            // NodeType: RECTANGLE
            // NodeId:   5:19
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-539.03796f, 19f, 64.58862f, 65f, 0f);
            canvas.RestoreState();


            // View:     rectangleView30
            // NodeName: Rectangle 6
            // NodeType: RECTANGLE
            // NodeId:   5:20
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-457.55695f, 32f, 90.42404f, 12f, 0f);
            canvas.RestoreState();


            // View:     rectangleView31
            // NodeName: Rectangle 7
            // NodeType: RECTANGLE
            // NodeId:   5:21
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(182, 181, 181);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-457.55695f, 53f, 201.7152f, 22f, 0f);
            canvas.RestoreState();


            // View:     rectangleView32
            // NodeName: Rectangle 8
            // NodeType: RECTANGLE
            // NodeId:   5:22
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(223, 223, 223);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-457.55695f, 17f, 31.797455f, 6f, 0f);
            canvas.RestoreState();


            // View:     rectangleView33
            // NodeName: Test 1
            // NodeType: RECTANGLE
            // NodeId:   5:23
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-545f, 26f, 314f, 64f, 0f);
            canvas.RestoreState();


            // View:     rectangleView34
            // NodeName: Rectangle 5
            // NodeType: RECTANGLE
            // NodeId:   5:24
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(255, 255, 255);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-531f, -382f, 287f, 21f, 29f);
            canvas.StrokeColor = Color.FromRgb(197, 197, 197);
            canvas.Alpha = 1;
            canvas.StrokeSize = 1;
            canvas.DrawRoundedRectangle(-531f, -382f, 287f, 21f, 29f);
            canvas.RestoreState();


            // View:     rectangleView35
            // NodeName: lupa 3
            // NodeType: RECTANGLE
            // NodeId:   104:9
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(-266f, -378f, 12f, 12f, 0f);
            canvas.RestoreState();


            // View:     rectangleView36
            // NodeName: lupa 2
            // NodeType: RECTANGLE
            // NodeId:   104:6
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(-284f, -376f, 10f, 9f, 0f);
            canvas.RestoreState();


            // View:     rectangleView37
            // NodeName: Rectangle 18
            // NodeType: RECTANGLE
            // NodeId:   104:10
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-291f, -381f, 1f, 19f, 0f);
            canvas.RestoreState();


            // View:     textView1
            // NodeName: Search there...
            // NodeType: TEXT
            // NodeId:   104:11
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(81, 81, 81);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 8f;
            canvas.DrawString(@"Search there...", -518f, -377f, 58f, 10f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     frameView6
            // NodeName: Phone
            // NodeType: FRAME
            // NodeId:   4:8
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(255, 255, 255);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-1412f, -1178f, 360f, 640f, 0f);
            canvas.RestoreState();


            // View:     rectangleView38
            // NodeName: Navbar
            // NodeType: RECTANGLE
            // NodeId:   4:9
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-1412f, -592f, 360f, 52f, 0f);
            canvas.RestoreState();


            // View:     rectangleView39
            // NodeName: Test 1
            // NodeType: RECTANGLE
            // NodeId:   4:12
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-1391f, -990f, 316f, 88f, 0f);
            canvas.RestoreState();


            // View:     rectangleView40
            // NodeName: Rectangle 5
            // NodeType: RECTANGLE
            // NodeId:   4:14
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-1391f, -1082f, 316f, 24f, 29f);
            canvas.RestoreState();


            // View:     frameView7
            // NodeName: Test
            // NodeType: GROUP
            // NodeId:   4:15
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView41
            // NodeName: Test 2
            // NodeType: RECTANGLE
            // NodeId:   4:16
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-1391f, -990f, 316f, 88f, 0f);
            canvas.RestoreState();


            // View:     rectangleView42
            // NodeName: Rectangle 1
            // NodeType: RECTANGLE
            // NodeId:   4:17
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-1377f, -982f, 65f, 65f, 0f);
            canvas.RestoreState();


            // View:     rectangleView43
            // NodeName: Rectangle 6
            // NodeType: RECTANGLE
            // NodeId:   4:18
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-1303f, -967f, 107f, 17f, 0f);
            canvas.RestoreState();


            // View:     rectangleView44
            // NodeName: Rectangle 7
            // NodeType: RECTANGLE
            // NodeId:   4:19
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(182, 181, 181);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-1303f, -942f, 62f, 8f, 0f);
            canvas.RestoreState();


            // View:     rectangleView45
            // NodeName: Rectangle 8
            // NodeType: RECTANGLE
            // NodeId:   4:20
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(189, 189, 189);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-1303f, -979f, 44f, 7f, 0f);
            canvas.RestoreState();


            // View:     frameView8
            // NodeName: Test
            // NodeType: GROUP
            // NodeId:   4:21
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView46
            // NodeName: Test 2
            // NodeType: RECTANGLE
            // NodeId:   4:22
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-1391f, -858f, 316f, 95f, 0f);
            canvas.RestoreState();


            // View:     rectangleView47
            // NodeName: Rectangle 1
            // NodeType: RECTANGLE
            // NodeId:   4:23
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-1377f, -850f, 65f, 65f, 0f);
            canvas.RestoreState();


            // View:     rectangleView48
            // NodeName: Rectangle 6
            // NodeType: RECTANGLE
            // NodeId:   4:24
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-1303f, -848f, 153f, 17f, 0f);
            canvas.RestoreState();


            // View:     rectangleView49
            // NodeName: Rectangle 7
            // NodeType: RECTANGLE
            // NodeId:   4:25
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(182, 181, 181);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-1303f, -826f, 62f, 8f, 0f);
            canvas.RestoreState();


            // View:     rectangleView50
            // NodeName: Rectangle 8
            // NodeType: RECTANGLE
            // NodeId:   4:26
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(189, 189, 189);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-1219f, -825f, 44f, 7f, 0f);
            canvas.RestoreState();


            // View:     frameView9
            // NodeName: Test
            // NodeType: GROUP
            // NodeId:   4:28
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView51
            // NodeName: Test 2
            // NodeType: RECTANGLE
            // NodeId:   4:29
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-1391f, -727f, 316f, 95f, 0f);
            canvas.RestoreState();


            // View:     rectangleView52
            // NodeName: Rectangle 1
            // NodeType: RECTANGLE
            // NodeId:   4:30
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-1377f, -719f, 65f, 65f, 0f);
            canvas.RestoreState();


            // View:     rectangleView53
            // NodeName: Rectangle 6
            // NodeType: RECTANGLE
            // NodeId:   4:31
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-1303f, -717f, 107f, 17f, 0f);
            canvas.RestoreState();


            // View:     rectangleView54
            // NodeName: Rectangle 7
            // NodeType: RECTANGLE
            // NodeId:   4:32
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(182, 181, 181);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-1303f, -695f, 62f, 8f, 0f);
            canvas.RestoreState();


            // View:     rectangleView55
            // NodeName: Rectangle 8
            // NodeType: RECTANGLE
            // NodeId:   4:33
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(189, 189, 189);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-1218f, -690f, 44f, 7f, 0f);
            canvas.RestoreState();


            // View:     rectangleView56
            // NodeName: Rectangle 9
            // NodeType: RECTANGLE
            // NodeId:   4:34
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(44, 40, 40);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-1391f, -1157f, 42f, 7f, 0f);
            canvas.RestoreState();


            // View:     rectangleView57
            // NodeName: Rectangle 11
            // NodeType: RECTANGLE
            // NodeId:   4:36
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(44, 40, 40);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-1391f, -1130f, 42f, 7f, 0f);
            canvas.RestoreState();


            // View:     rectangleView58
            // NodeName: Rectangle 10
            // NodeType: RECTANGLE
            // NodeId:   4:35
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(44, 40, 40);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-1391f, -1144f, 42f, 7f, 0f);
            canvas.RestoreState();


            // View:     textView2
            // NodeName: RECENTLY UPLOADED
            // NodeType: TEXT
            // NodeId:   4:37
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(0, 0, 0);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("Inter", 400, FontStyleType.Normal);
            canvas.FontSize = 15f;
            canvas.DrawString(@"RECENTLY UPLOADED", -1312f, -1033f, 293f, 19f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     textView3
            // NodeName: VIP
            // NodeType: TEXT
            // NodeId:   4:38
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(0, 0, 0);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("Inter", 400, FontStyleType.Normal);
            canvas.FontSize = 15f;
            canvas.DrawString(@"VIP", -1112f, -792f, 24f, 24f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     frameView10
            // NodeName: Desktop 
            // NodeType: FRAME
            // NodeId:   3:5
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(255, 255, 255);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-125f, -476f, 1440f, 1024f, 0f);
            canvas.RestoreState();


            // View:     frameView11
            // NodeName: Navmenu
            // NodeType: GROUP
            // NodeId:   3:50
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView59
            // NodeName: Rectangle 14
            // NodeType: RECTANGLE
            // NodeId:   3:35
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-125f, -476f, 300f, 1024f, 0f);
            canvas.RestoreState();


            // View:     rectangleView60
            // NodeName: Rectangle 9
            // NodeType: RECTANGLE
            // NodeId:   3:36
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-125f, -367f, 300f, 31f, 0f);
            canvas.RestoreState();


            // View:     rectangleView61
            // NodeName: Rectangle 15
            // NodeType: RECTANGLE
            // NodeId:   3:37
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-125f, -327f, 300f, 31f, 0f);
            canvas.RestoreState();


            // View:     rectangleView62
            // NodeName: Rectangle 16
            // NodeType: RECTANGLE
            // NodeId:   3:39
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-125f, -287f, 300f, 31f, 0f);
            canvas.RestoreState();


            // View:     rectangleView63
            // NodeName: Rectangle 17
            // NodeType: RECTANGLE
            // NodeId:   3:40
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-125f, -247f, 300f, 31f, 0f);
            canvas.RestoreState();


            // View:     frameView12
            // NodeName: Tests
            // NodeType: GROUP
            // NodeId:   3:128
            canvas.SaveState();
            canvas.RestoreState();


            // View:     frameView13
            // NodeName: Test by D
            // NodeType: GROUP
            // NodeId:   3:41
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView64
            // NodeName: Test 2
            // NodeType: RECTANGLE
            // NodeId:   3:42
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(202f, -365f, 512.987f, 125f, 0f);
            canvas.RestoreState();


            // View:     rectangleView65
            // NodeName: Rectangle 1
            // NodeType: RECTANGLE
            // NodeId:   3:43
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(211.74026f, -355.25974f, 105.51947f, 105.51947f, 0f);
            canvas.RestoreState();


            // View:     rectangleView66
            // NodeName: Rectangle 6
            // NodeType: RECTANGLE
            // NodeId:   3:44
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(344.85715f, -334.15585f, 147.72726f, 19.48053f, 0f);
            canvas.RestoreState();


            // View:     rectangleView67
            // NodeName: Rectangle 7
            // NodeType: RECTANGLE
            // NodeId:   3:45
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(182, 181, 181);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(344.85715f, -300.06494f, 329.54544f, 35.714294f, 0f);
            canvas.RestoreState();


            // View:     rectangleView68
            // NodeName: Rectangle 8
            // NodeType: RECTANGLE
            // NodeId:   3:46
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(223, 223, 223);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(344.85715f, -358.5065f, 51.94806f, 9.740265f, 0f);
            canvas.RestoreState();


            // View:     rectangleView69
            // NodeName: Test 1
            // NodeType: RECTANGLE
            // NodeId:   3:47
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(202f, -343.89612f, 512.987f, 103.8961f, 0f);
            canvas.RestoreState();


            // View:     frameView14
            // NodeName: Test by D
            // NodeType: GROUP
            // NodeId:   3:86
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView70
            // NodeName: Test 2
            // NodeType: RECTANGLE
            // NodeId:   3:87
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(742f, -365f, 512.98706f, 125f, 0f);
            canvas.RestoreState();


            // View:     rectangleView71
            // NodeName: Rectangle 1
            // NodeType: RECTANGLE
            // NodeId:   3:88
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(751.74023f, -355.25974f, 105.51947f, 105.51947f, 0f);
            canvas.RestoreState();


            // View:     rectangleView72
            // NodeName: Rectangle 6
            // NodeType: RECTANGLE
            // NodeId:   3:89
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(884.8572f, -334.15585f, 147.7273f, 19.48053f, 0f);
            canvas.RestoreState();


            // View:     rectangleView73
            // NodeName: Rectangle 7
            // NodeType: RECTANGLE
            // NodeId:   3:90
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(182, 181, 181);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(884.8572f, -300.06494f, 329.5454f, 35.714294f, 0f);
            canvas.RestoreState();


            // View:     rectangleView74
            // NodeName: Rectangle 8
            // NodeType: RECTANGLE
            // NodeId:   3:91
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(223, 223, 223);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(884.8572f, -358.5065f, 51.94806f, 9.740265f, 0f);
            canvas.RestoreState();


            // View:     rectangleView75
            // NodeName: Test 1
            // NodeType: RECTANGLE
            // NodeId:   3:92
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(742f, -343.89612f, 512.98706f, 103.8961f, 0f);
            canvas.RestoreState();


            // View:     frameView15
            // NodeName: Test by D
            // NodeType: GROUP
            // NodeId:   3:93
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView76
            // NodeName: Test 2
            // NodeType: RECTANGLE
            // NodeId:   3:94
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(742f, -214f, 512.98706f, 125f, 0f);
            canvas.RestoreState();


            // View:     rectangleView77
            // NodeName: Rectangle 1
            // NodeType: RECTANGLE
            // NodeId:   3:95
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(751.74023f, -204.25974f, 105.51947f, 105.51948f, 0f);
            canvas.RestoreState();


            // View:     rectangleView78
            // NodeName: Rectangle 6
            // NodeType: RECTANGLE
            // NodeId:   3:96
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(884.8572f, -183.15584f, 147.7273f, 19.480515f, 0f);
            canvas.RestoreState();


            // View:     rectangleView79
            // NodeName: Rectangle 7
            // NodeType: RECTANGLE
            // NodeId:   3:97
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(182, 181, 181);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(884.8572f, -149.06494f, 329.5454f, 35.714287f, 0f);
            canvas.RestoreState();


            // View:     rectangleView80
            // NodeName: Rectangle 8
            // NodeType: RECTANGLE
            // NodeId:   3:98
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(223, 223, 223);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(884.8572f, -207.5065f, 51.94806f, 9.740265f, 0f);
            canvas.RestoreState();


            // View:     rectangleView81
            // NodeName: Test 1
            // NodeType: RECTANGLE
            // NodeId:   3:99
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(742f, -192.8961f, 512.98706f, 103.8961f, 0f);
            canvas.RestoreState();


            // View:     frameView16
            // NodeName: Test by D
            // NodeType: GROUP
            // NodeId:   3:100
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView82
            // NodeName: Test 2
            // NodeType: RECTANGLE
            // NodeId:   3:101
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(742f, -63f, 512.98706f, 125f, 0f);
            canvas.RestoreState();


            // View:     rectangleView83
            // NodeName: Rectangle 1
            // NodeType: RECTANGLE
            // NodeId:   3:102
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(751.74023f, -53.25974f, 105.51947f, 105.51948f, 0f);
            canvas.RestoreState();


            // View:     rectangleView84
            // NodeName: Rectangle 6
            // NodeType: RECTANGLE
            // NodeId:   3:103
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(884.8572f, -32.155846f, 147.7273f, 19.48052f, 0f);
            canvas.RestoreState();


            // View:     rectangleView85
            // NodeName: Rectangle 7
            // NodeType: RECTANGLE
            // NodeId:   3:104
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(182, 181, 181);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(884.8572f, 1.9350662f, 329.5454f, 35.714287f, 0f);
            canvas.RestoreState();


            // View:     rectangleView86
            // NodeName: Rectangle 8
            // NodeType: RECTANGLE
            // NodeId:   3:105
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(223, 223, 223);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(884.8572f, -56.506493f, 51.94806f, 9.740261f, 0f);
            canvas.RestoreState();


            // View:     rectangleView87
            // NodeName: Test 1
            // NodeType: RECTANGLE
            // NodeId:   3:106
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(742f, -41.896103f, 512.98706f, 103.8961f, 0f);
            canvas.RestoreState();


            // View:     frameView17
            // NodeName: Test by D
            // NodeType: GROUP
            // NodeId:   3:107
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView88
            // NodeName: Test 2
            // NodeType: RECTANGLE
            // NodeId:   3:108
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(742f, 88f, 512.98706f, 125f, 0f);
            canvas.RestoreState();


            // View:     rectangleView89
            // NodeName: Rectangle 1
            // NodeType: RECTANGLE
            // NodeId:   3:109
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(751.74023f, 97.74026f, 105.51947f, 105.51948f, 0f);
            canvas.RestoreState();


            // View:     rectangleView90
            // NodeName: Rectangle 6
            // NodeType: RECTANGLE
            // NodeId:   3:110
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(884.8572f, 118.844154f, 147.7273f, 19.480522f, 0f);
            canvas.RestoreState();


            // View:     rectangleView91
            // NodeName: Rectangle 7
            // NodeType: RECTANGLE
            // NodeId:   3:111
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(182, 181, 181);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(884.8572f, 152.93506f, 329.5454f, 35.714294f, 0f);
            canvas.RestoreState();


            // View:     rectangleView92
            // NodeName: Rectangle 8
            // NodeType: RECTANGLE
            // NodeId:   3:112
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(223, 223, 223);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(884.8572f, 94.49351f, 51.94806f, 9.740257f, 0f);
            canvas.RestoreState();


            // View:     rectangleView93
            // NodeName: Test 1
            // NodeType: RECTANGLE
            // NodeId:   3:113
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(742f, 109.1039f, 512.98706f, 103.8961f, 0f);
            canvas.RestoreState();


            // View:     frameView18
            // NodeName: Test by D
            // NodeType: GROUP
            // NodeId:   3:114
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView94
            // NodeName: Test 2
            // NodeType: RECTANGLE
            // NodeId:   3:115
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(742f, 239f, 512.98706f, 125f, 0f);
            canvas.RestoreState();


            // View:     rectangleView95
            // NodeName: Rectangle 1
            // NodeType: RECTANGLE
            // NodeId:   3:116
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(751.74023f, 248.74026f, 105.51947f, 105.51947f, 0f);
            canvas.RestoreState();


            // View:     rectangleView96
            // NodeName: Rectangle 6
            // NodeType: RECTANGLE
            // NodeId:   3:117
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(884.8572f, 269.84415f, 147.7273f, 19.48053f, 0f);
            canvas.RestoreState();


            // View:     rectangleView97
            // NodeName: Rectangle 7
            // NodeType: RECTANGLE
            // NodeId:   3:118
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(182, 181, 181);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(884.8572f, 303.93506f, 329.5454f, 35.714294f, 0f);
            canvas.RestoreState();


            // View:     rectangleView98
            // NodeName: Rectangle 8
            // NodeType: RECTANGLE
            // NodeId:   3:119
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(223, 223, 223);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(884.8572f, 245.4935f, 51.94806f, 9.740265f, 0f);
            canvas.RestoreState();


            // View:     rectangleView99
            // NodeName: Test 1
            // NodeType: RECTANGLE
            // NodeId:   3:120
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(742f, 260.10388f, 512.98706f, 103.89612f, 0f);
            canvas.RestoreState();


            // View:     frameView19
            // NodeName: Test by D
            // NodeType: GROUP
            // NodeId:   3:121
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView100
            // NodeName: Test 2
            // NodeType: RECTANGLE
            // NodeId:   3:122
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(742f, 390f, 512.98706f, 125f, 0f);
            canvas.RestoreState();


            // View:     rectangleView101
            // NodeName: Rectangle 1
            // NodeType: RECTANGLE
            // NodeId:   3:123
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(751.74023f, 399.74026f, 105.51947f, 105.51947f, 0f);
            canvas.RestoreState();


            // View:     rectangleView102
            // NodeName: Rectangle 6
            // NodeType: RECTANGLE
            // NodeId:   3:124
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(884.8572f, 420.84415f, 147.7273f, 19.48053f, 0f);
            canvas.RestoreState();


            // View:     rectangleView103
            // NodeName: Rectangle 7
            // NodeType: RECTANGLE
            // NodeId:   3:125
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(182, 181, 181);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(884.8572f, 454.93506f, 329.5454f, 35.714294f, 0f);
            canvas.RestoreState();


            // View:     rectangleView104
            // NodeName: Rectangle 8
            // NodeType: RECTANGLE
            // NodeId:   3:126
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(223, 223, 223);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(884.8572f, 396.4935f, 51.94806f, 9.740265f, 0f);
            canvas.RestoreState();


            // View:     rectangleView105
            // NodeName: Test 1
            // NodeType: RECTANGLE
            // NodeId:   3:127
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(742f, 411.10388f, 512.98706f, 103.89612f, 0f);
            canvas.RestoreState();


            // View:     frameView20
            // NodeName: Test by D
            // NodeType: GROUP
            // NodeId:   3:51
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView106
            // NodeName: Test 2
            // NodeType: RECTANGLE
            // NodeId:   3:52
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(202f, -214f, 512.987f, 125f, 0f);
            canvas.RestoreState();


            // View:     rectangleView107
            // NodeName: Rectangle 1
            // NodeType: RECTANGLE
            // NodeId:   3:53
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(211.74026f, -204.25974f, 105.51947f, 105.51948f, 0f);
            canvas.RestoreState();


            // View:     rectangleView108
            // NodeName: Rectangle 6
            // NodeType: RECTANGLE
            // NodeId:   3:54
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(344.85715f, -183.15584f, 147.72726f, 19.480515f, 0f);
            canvas.RestoreState();


            // View:     rectangleView109
            // NodeName: Rectangle 7
            // NodeType: RECTANGLE
            // NodeId:   3:55
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(182, 181, 181);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(344.85715f, -149.06494f, 329.54544f, 35.714287f, 0f);
            canvas.RestoreState();


            // View:     rectangleView110
            // NodeName: Rectangle 8
            // NodeType: RECTANGLE
            // NodeId:   3:56
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(223, 223, 223);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(344.85715f, -207.5065f, 51.94806f, 9.740265f, 0f);
            canvas.RestoreState();


            // View:     rectangleView111
            // NodeName: Test 1
            // NodeType: RECTANGLE
            // NodeId:   3:57
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(202f, -192.8961f, 512.987f, 103.8961f, 0f);
            canvas.RestoreState();


            // View:     frameView21
            // NodeName: Test by D
            // NodeType: GROUP
            // NodeId:   3:58
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView112
            // NodeName: Test 2
            // NodeType: RECTANGLE
            // NodeId:   3:59
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(202f, -63f, 512.987f, 125f, 0f);
            canvas.RestoreState();


            // View:     rectangleView113
            // NodeName: Rectangle 1
            // NodeType: RECTANGLE
            // NodeId:   3:60
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(211.74026f, -53.25974f, 105.51947f, 105.51948f, 0f);
            canvas.RestoreState();


            // View:     rectangleView114
            // NodeName: Rectangle 6
            // NodeType: RECTANGLE
            // NodeId:   3:61
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(344.85715f, -32.155846f, 147.72726f, 19.48052f, 0f);
            canvas.RestoreState();


            // View:     rectangleView115
            // NodeName: Rectangle 7
            // NodeType: RECTANGLE
            // NodeId:   3:62
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(182, 181, 181);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(344.85715f, 1.9350662f, 329.54544f, 35.714287f, 0f);
            canvas.RestoreState();


            // View:     rectangleView116
            // NodeName: Rectangle 8
            // NodeType: RECTANGLE
            // NodeId:   3:63
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(223, 223, 223);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(344.85715f, -56.506493f, 51.94806f, 9.740261f, 0f);
            canvas.RestoreState();


            // View:     rectangleView117
            // NodeName: Test 1
            // NodeType: RECTANGLE
            // NodeId:   3:64
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(202f, -41.896103f, 512.987f, 103.8961f, 0f);
            canvas.RestoreState();


            // View:     frameView22
            // NodeName: Test by D
            // NodeType: GROUP
            // NodeId:   3:65
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView118
            // NodeName: Test 2
            // NodeType: RECTANGLE
            // NodeId:   3:66
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(202f, 88f, 512.987f, 125f, 0f);
            canvas.RestoreState();


            // View:     rectangleView119
            // NodeName: Rectangle 1
            // NodeType: RECTANGLE
            // NodeId:   3:67
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(211.74026f, 97.74026f, 105.51947f, 105.51948f, 0f);
            canvas.RestoreState();


            // View:     rectangleView120
            // NodeName: Rectangle 6
            // NodeType: RECTANGLE
            // NodeId:   3:68
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(344.85715f, 118.844154f, 147.72726f, 19.480522f, 0f);
            canvas.RestoreState();


            // View:     rectangleView121
            // NodeName: Rectangle 7
            // NodeType: RECTANGLE
            // NodeId:   3:69
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(182, 181, 181);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(344.85715f, 152.93506f, 329.54544f, 35.714294f, 0f);
            canvas.RestoreState();


            // View:     rectangleView122
            // NodeName: Rectangle 8
            // NodeType: RECTANGLE
            // NodeId:   3:70
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(223, 223, 223);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(344.85715f, 94.49351f, 51.94806f, 9.740257f, 0f);
            canvas.RestoreState();


            // View:     rectangleView123
            // NodeName: Test 1
            // NodeType: RECTANGLE
            // NodeId:   3:71
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(202f, 109.1039f, 512.987f, 103.8961f, 0f);
            canvas.RestoreState();


            // View:     frameView23
            // NodeName: Test by D
            // NodeType: GROUP
            // NodeId:   3:72
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView124
            // NodeName: Test 2
            // NodeType: RECTANGLE
            // NodeId:   3:73
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(202f, 239f, 512.987f, 125f, 0f);
            canvas.RestoreState();


            // View:     rectangleView125
            // NodeName: Rectangle 1
            // NodeType: RECTANGLE
            // NodeId:   3:74
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(211.74026f, 248.74026f, 105.51947f, 105.51947f, 0f);
            canvas.RestoreState();


            // View:     rectangleView126
            // NodeName: Rectangle 6
            // NodeType: RECTANGLE
            // NodeId:   3:75
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(344.85715f, 269.84415f, 147.72726f, 19.48053f, 0f);
            canvas.RestoreState();


            // View:     rectangleView127
            // NodeName: Rectangle 7
            // NodeType: RECTANGLE
            // NodeId:   3:76
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(182, 181, 181);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(344.85715f, 303.93506f, 329.54544f, 35.714294f, 0f);
            canvas.RestoreState();


            // View:     rectangleView128
            // NodeName: Rectangle 8
            // NodeType: RECTANGLE
            // NodeId:   3:77
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(223, 223, 223);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(344.85715f, 245.4935f, 51.94806f, 9.740265f, 0f);
            canvas.RestoreState();


            // View:     rectangleView129
            // NodeName: Test 1
            // NodeType: RECTANGLE
            // NodeId:   3:78
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(202f, 260.10388f, 512.987f, 103.89612f, 0f);
            canvas.RestoreState();


            // View:     frameView24
            // NodeName: Test by D
            // NodeType: GROUP
            // NodeId:   3:79
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView130
            // NodeName: Test 2
            // NodeType: RECTANGLE
            // NodeId:   3:80
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(202f, 390f, 512.987f, 125f, 0f);
            canvas.RestoreState();


            // View:     rectangleView131
            // NodeName: Rectangle 1
            // NodeType: RECTANGLE
            // NodeId:   3:81
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(211.74026f, 399.74026f, 105.51947f, 105.51947f, 0f);
            canvas.RestoreState();


            // View:     rectangleView132
            // NodeName: Rectangle 6
            // NodeType: RECTANGLE
            // NodeId:   3:82
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(344.85715f, 420.84415f, 147.72726f, 19.48053f, 0f);
            canvas.RestoreState();


            // View:     rectangleView133
            // NodeName: Rectangle 7
            // NodeType: RECTANGLE
            // NodeId:   3:83
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(182, 181, 181);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(344.85715f, 454.93506f, 329.54544f, 35.714294f, 0f);
            canvas.RestoreState();


            // View:     rectangleView134
            // NodeName: Rectangle 8
            // NodeType: RECTANGLE
            // NodeId:   3:84
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(223, 223, 223);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(344.85715f, 396.4935f, 51.94806f, 9.740265f, 0f);
            canvas.RestoreState();


            // View:     rectangleView135
            // NodeName: Test 1
            // NodeType: RECTANGLE
            // NodeId:   3:85
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(202f, 411.10388f, 512.987f, 103.89612f, 0f);
            canvas.RestoreState();


            // View:     rectangleView136
            // NodeName: Search area
            // NodeType: RECTANGLE
            // NodeId:   3:49
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-125f, -476f, 1440f, 85f, 0f);
            canvas.RestoreState();


            // View:     rectangleView137
            // NodeName: Textarea
            // NodeType: RECTANGLE
            // NodeId:   3:48
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(146, 146, 146);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(202f, -461f, 546f, 50f, 29f);
            canvas.RestoreState();


            // View:     rectangleView138
            // NodeName: Rectangle 12
            // NodeType: RECTANGLE
            // NodeId:   3:129
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(44, 40, 40);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-106f, -451f, 42f, 7f, 0f);
            canvas.RestoreState();


            // View:     rectangleView139
            // NodeName: Rectangle 13
            // NodeType: RECTANGLE
            // NodeId:   3:130
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(44, 40, 40);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-106f, -424f, 42f, 7f, 0f);
            canvas.RestoreState();


            // View:     rectangleView140
            // NodeName: Rectangle 14
            // NodeType: RECTANGLE
            // NodeId:   3:131
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(44, 40, 40);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-106f, -438f, 42f, 7f, 0f);
            canvas.RestoreState();


            // View:     rectangleView141
            // NodeName: Rectangle 12
            // NodeType: RECTANGLE
            // NodeId:   4:39
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(255, 231, 12);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(-1130f, -788f, 11f, 16f, 0f);
            canvas.RestoreState();


            // View:     frameView25
            // NodeName: Home page
            // NodeType: FRAME
            // NodeId:   109:20
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(255, 255, 255);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1355f, -697f, 390f, 844f, 0f);
            canvas.RestoreState();


            // View:     rectangleView142
            // NodeName: image 5
            // NodeType: RECTANGLE
            // NodeId:   112:5
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(1366f, -164f, 367f, 288f, 0f);
            canvas.RestoreState();


            // View:     rectangleView143
            // NodeName: image 4
            // NodeType: RECTANGLE
            // NodeId:   112:4
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(1366f, -436f, 367f, 288f, 0f);
            canvas.RestoreState();


            // View:     rectangleView144
            // NodeName: image 3
            // NodeType: RECTANGLE
            // NodeId:   112:3
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(1366f, -708f, 367f, 288f, 0f);
            canvas.RestoreState();


            // View:     rectangleView145
            // NodeName: Headtext
            // NodeType: RECTANGLE
            // NodeId:   109:70
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(167, 167, 167);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1381f, -589f, 126f, 21f, 0f);
            canvas.RestoreState();


            // View:     textView4
            // NodeName: Recently uploaded
            // NodeType: TEXT
            // NodeId:   109:71
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(81, 81, 81);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 24f;
            canvas.DrawString(@"Recently uploaded", 1376f, -562f, 260f, 19f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     frameView26
            // NodeName: Test by D
            // NodeType: GROUP
            // NodeId:   109:72
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView146
            // NodeName: Rectangle 19
            // NodeType: RECTANGLE
            // NodeId:   112:9
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(244, 244, 244);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1419f, -495f, 304f, 103f, 10f);
            canvas.RestoreState();


            // View:     rectangleView147
            // NodeName: Rectangle 20
            // NodeType: RECTANGLE
            // NodeId:   112:10
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(236, 236, 236);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1433f, -479f, 290f, 72f, 0f);
            canvas.RestoreState();


            // View:     textView5
            // NodeName: Vegetables
            // NodeType: TEXT
            // NodeId:   109:113
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(81, 81, 81);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 19f;
            canvas.DrawString(@"Vegetables", 1497f, -476f, 123f, 23f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     textView6
            // NodeName: Green, health, useful, strength, zucchini, cucumber, beetroot, tomato, red, pepper, food, cooking, peas, dish, autumn, pumpkin
            // NodeType: TEXT
            // NodeId:   112:6
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(38, 38, 38);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Light", 300, FontStyleType.Normal);
            canvas.FontSize = 9f;
            canvas.DrawString(@"Green, health, useful, strength, zucchini, cucumber, beetroot, tomato, red, pepper, food, cooking, peas, dish, autumn, pumpkin", 1497f, -445f, 226f, 33f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     textView7
            // NodeName: Dec, 12, 2022
            // NodeType: TEXT
            // NodeId:   112:7
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(92, 92, 92);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Light", 300, FontStyleType.Normal);
            canvas.FontSize = 8f;
            canvas.DrawString(@"Dec, 12, 2022", 1496f, -493f, 50f, 10f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     elipseView
            // NodeName: Ellipse 1
            // NodeType: ELLIPSE
            // NodeId:   109:112
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillEllipse(1376f, -499f, 109f, 109f);
            canvas.StrokeColor = Color.FromRgb(165, 165, 165);
            canvas.Alpha = 1;
            canvas.StrokeSize = 2;
            canvas.DrawEllipse(1376f, -499f, 109f, 109f);
            canvas.RestoreState();


            // View:     textView8
            // NodeName: Miyagi B.
            // NodeType: TEXT
            // NodeId:   112:8
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(88, 88, 88);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 9f;
            canvas.DrawString(@"Miyagi B.", 1676f, -405f, 47f, 11f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     frameView27
            // NodeName: Test by D
            // NodeType: GROUP
            // NodeId:   112:26
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView148
            // NodeName: Rectangle 19
            // NodeType: RECTANGLE
            // NodeId:   112:27
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(238, 238, 238);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1376f, -233f, 304f, 103f, 10f);
            canvas.RestoreState();


            // View:     rectangleView149
            // NodeName: Rectangle 20
            // NodeType: RECTANGLE
            // NodeId:   112:28
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(226, 226, 226);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1376f, -217f, 290f, 72f, 0f);
            canvas.RestoreState();


            // View:     textView9
            // NodeName: Airline
            // NodeType: TEXT
            // NodeId:   112:29
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(81, 81, 81);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 19f;
            canvas.DrawString(@"Airline", 1383f, -214f, 123f, 23f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     textView10
            // NodeName: Plane, folding table, seat, stewardess, window, food, sleep, business. wing, business class, economy class, flight attendant, curtain, drinks
            // NodeType: TEXT
            // NodeId:   112:30
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(38, 38, 38);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Light", 300, FontStyleType.Normal);
            canvas.FontSize = 9f;
            canvas.DrawString(@"Plane, folding table, seat, stewardess, window, food, sleep, business. wing, business class, economy class, flight attendant, curtain, drinks", 1383f, -183f, 226f, 33f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     textView11
            // NodeName: Oct, 01, 2022
            // NodeType: TEXT
            // NodeId:   112:31
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(92, 92, 92);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Light", 300, FontStyleType.Normal);
            canvas.FontSize = 8f;
            canvas.DrawString(@"Oct, 01, 2022", 1382f, -231f, 49f, 10f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     elipseView1
            // NodeName: Ellipse 1
            // NodeType: ELLIPSE
            // NodeId:   112:32
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillEllipse(1614f, -237f, 109f, 109f);
            canvas.StrokeColor = Color.FromRgb(165, 165, 165);
            canvas.Alpha = 1;
            canvas.StrokeSize = 2;
            canvas.DrawEllipse(1614f, -237f, 109f, 109f);
            canvas.RestoreState();


            // View:     textView12
            // NodeName: You
            // NodeType: TEXT
            // NodeId:   112:33
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(88, 88, 88);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 9f;
            canvas.DrawString(@"You", 1383f, -143f, 47f, 11f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     frameView28
            // NodeName: Test by D
            // NodeType: GROUP
            // NodeId:   112:18
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView150
            // NodeName: Rectangle 19
            // NodeType: RECTANGLE
            // NodeId:   112:19
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(244, 244, 244);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1419f, -364f, 304f, 103f, 10f);
            canvas.RestoreState();


            // View:     rectangleView151
            // NodeName: Rectangle 20
            // NodeType: RECTANGLE
            // NodeId:   112:20
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(236, 236, 236);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1433f, -348f, 290f, 72f, 0f);
            canvas.RestoreState();


            // View:     textView13
            // NodeName: Fruits
            // NodeType: TEXT
            // NodeId:   112:21
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(81, 81, 81);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 19f;
            canvas.DrawString(@"Fruits", 1497f, -345f, 123f, 23f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     textView14
            // NodeName: Apple, freshness, vitamins, green, yellow, banana, sweet, juice, fruit salad, peel, wedge
            // NodeType: TEXT
            // NodeId:   112:22
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(38, 38, 38);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Light", 300, FontStyleType.Normal);
            canvas.FontSize = 9f;
            canvas.DrawString(@"Apple, freshness, vitamins, green, yellow, banana, sweet, juice, fruit salad, peel, wedge", 1497f, -314f, 226f, 22f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     textView15
            // NodeName: Oct, 04, 2022
            // NodeType: TEXT
            // NodeId:   112:23
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(92, 92, 92);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Light", 300, FontStyleType.Normal);
            canvas.FontSize = 8f;
            canvas.DrawString(@"Oct, 04, 2022", 1496f, -362f, 52f, 10f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     elipseView2
            // NodeName: Ellipse 1
            // NodeType: ELLIPSE
            // NodeId:   112:24
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillEllipse(1376f, -368f, 109f, 109f);
            canvas.StrokeColor = Color.FromRgb(165, 165, 165);
            canvas.Alpha = 1;
            canvas.StrokeSize = 2;
            canvas.DrawEllipse(1376f, -368f, 109f, 109f);
            canvas.RestoreState();


            // View:     textView16
            // NodeName: Artur K.
            // NodeType: TEXT
            // NodeId:   112:25
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(88, 88, 88);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 9f;
            canvas.DrawString(@"Artur K.", 1684f, -274f, 47f, 11f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     frameView29
            // NodeName: Test by D
            // NodeType: GROUP
            // NodeId:   112:50
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView152
            // NodeName: Rectangle 19
            // NodeType: RECTANGLE
            // NodeId:   112:51
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(244, 244, 244);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1419f, -102f, 304f, 103f, 10f);
            canvas.RestoreState();


            // View:     rectangleView153
            // NodeName: Rectangle 20
            // NodeType: RECTANGLE
            // NodeId:   112:52
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(236, 236, 236);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1433f, -86f, 290f, 72f, 0f);
            canvas.RestoreState();


            // View:     textView17
            // NodeName: Weapons
            // NodeType: TEXT
            // NodeId:   112:53
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(81, 81, 81);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 19f;
            canvas.DrawString(@"Weapons", 1497f, -83f, 123f, 23f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     textView18
            // NodeName: Danger, pistol, bullet, black, brown, plastic, toy, collection, shot, weapon, license, target, charge, death
            // NodeType: TEXT
            // NodeId:   112:54
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(38, 38, 38);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Light", 300, FontStyleType.Normal);
            canvas.FontSize = 9f;
            canvas.DrawString(@"Danger, pistol, bullet, black, brown, plastic, toy, collection, shot, weapon, license, target, charge, death", 1497f, -52f, 226f, 33f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     textView19
            // NodeName: Sep, 28, 2022
            // NodeType: TEXT
            // NodeId:   112:55
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(92, 92, 92);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Light", 300, FontStyleType.Normal);
            canvas.FontSize = 8f;
            canvas.DrawString(@"Sep, 28, 2022", 1496f, -100f, 51f, 10f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     elipseView3
            // NodeName: Ellipse 1
            // NodeType: ELLIPSE
            // NodeId:   112:56
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillEllipse(1376f, -106f, 109f, 109f);
            canvas.StrokeColor = Color.FromRgb(165, 165, 165);
            canvas.Alpha = 1;
            canvas.StrokeSize = 2;
            canvas.DrawEllipse(1376f, -106f, 109f, 109f);
            canvas.RestoreState();


            // View:     textView20
            // NodeName: Peter P.
            // NodeType: TEXT
            // NodeId:   112:57
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(88, 88, 88);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 9f;
            canvas.DrawString(@"Peter P.", 1683f, -12f, 47f, 11f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     frameView30
            // NodeName: Test by D
            // NodeType: GROUP
            // NodeId:   112:66
            canvas.SaveState();
            canvas.RestoreState();


            // View:     rectangleView154
            // NodeName: Rectangle 19
            // NodeType: RECTANGLE
            // NodeId:   112:67
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(244, 244, 244);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1419f, 29f, 304f, 103f, 10f);
            canvas.RestoreState();


            // View:     rectangleView155
            // NodeName: Rectangle 20
            // NodeType: RECTANGLE
            // NodeId:   112:68
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(236, 236, 236);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1433f, 45f, 290f, 72f, 0f);
            canvas.RestoreState();


            // View:     textView21
            // NodeName: Vegetables
            // NodeType: TEXT
            // NodeId:   112:69
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(81, 81, 81);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 19f;
            canvas.DrawString(@"Vegetables", 1497f, 48f, 123f, 23f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     textView22
            // NodeName: Green, health, useful, strength, zucchini, cucumber, beetroot, tomato, red, pepper, food, cooking, peas, dish, autumn, pumpkin
            // NodeType: TEXT
            // NodeId:   112:70
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(38, 38, 38);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Light", 300, FontStyleType.Normal);
            canvas.FontSize = 9f;
            canvas.DrawString(@"Green, health, useful, strength, zucchini, cucumber, beetroot, tomato, red, pepper, food, cooking, peas, dish, autumn, pumpkin", 1497f, 79f, 226f, 33f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     textView23
            // NodeName: Aug, 19, 2022
            // NodeType: TEXT
            // NodeId:   112:71
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(92, 92, 92);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Light", 300, FontStyleType.Normal);
            canvas.FontSize = 8f;
            canvas.DrawString(@"Aug, 19, 2022", 1496f, 31f, 50f, 10f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     elipseView4
            // NodeName: Ellipse 1
            // NodeType: ELLIPSE
            // NodeId:   112:72
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillEllipse(1376f, 25f, 109f, 109f);
            canvas.StrokeColor = Color.FromRgb(165, 165, 165);
            canvas.Alpha = 1;
            canvas.StrokeSize = 2;
            canvas.DrawEllipse(1376f, 25f, 109f, 109f);
            canvas.RestoreState();


            // View:     textView24
            // NodeName: Miyagi B.
            // NodeType: TEXT
            // NodeId:   112:73
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(88, 88, 88);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 9f;
            canvas.DrawString(@"Miyagi B.", 1676f, 119f, 47f, 11f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     rectangleView156
            // NodeName: Rectangle 5
            // NodeType: RECTANGLE
            // NodeId:   109:107
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(255, 255, 255);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1374f, -637f, 352f, 41f, 29f);
            canvas.StrokeColor = Color.FromRgb(197, 197, 197);
            canvas.Alpha = 1;
            canvas.StrokeSize = 1;
            canvas.DrawRoundedRectangle(1374f, -637f, 352f, 41f, 29f);
            canvas.RestoreState();


            // View:     rectangleView157
            // NodeName: lupa 3
            // NodeType: RECTANGLE
            // NodeId:   109:108
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(1697f, -626f, 18f, 18f, 0f);
            canvas.RestoreState();


            // View:     rectangleView158
            // NodeName: lupa 2
            // NodeType: RECTANGLE
            // NodeId:   109:109
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(1668f, -624f, 17f, 15f, 0f);
            canvas.RestoreState();


            // View:     rectangleView159
            // NodeName: Rectangle 18
            // NodeType: RECTANGLE
            // NodeId:   109:110
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1662f, -636f, 1f, 39f, 0f);
            canvas.RestoreState();


            // View:     textView25
            // NodeName: Search there...
            // NodeType: TEXT
            // NodeId:   109:111
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(81, 81, 81);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 14f;
            canvas.DrawString(@"Search there...", 1393f, -626f, 112f, 12f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     rectangleView160
            // NodeName: Navbar
            // NodeType: RECTANGLE
            // NodeId:   109:69
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1355f, 56f, 390f, 91f, 0f);
            canvas.RestoreState();


            // View:     rectangleView161
            // NodeName: image 6
            // NodeType: RECTANGLE
            // NodeId:   112:77
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(1394f, 82f, 39f, 39f, 0f);
            canvas.RestoreState();


            // View:     rectangleView162
            // NodeName: home 1
            // NodeType: RECTANGLE
            // NodeId:   117:131
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(1387f, 76f, 59f, 59f, 0f);
            canvas.RestoreState();


            // View:     rectangleView163
            // NodeName: shop 1
            // NodeType: RECTANGLE
            // NodeId:   121:145
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(1559f, 78f, 58f, 54f, 0f);
            canvas.RestoreState();


            // View:     rectangleView164
            // NodeName: Rectangle 26
            // NodeType: RECTANGLE
            // NodeId:   125:238
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(81, 81, 81);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1376f, -524f, 109f, 4f, 4f);
            canvas.RestoreState();


            // View:     frameView31
            // NodeName: Shop
            // NodeType: FRAME
            // NodeId:   125:150
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(255, 255, 255);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1785f, -697f, 390f, 844f, 0f);
            canvas.RestoreState();


            // View:     rectangleView165
            // NodeName: image 5
            // NodeType: RECTANGLE
            // NodeId:   125:151
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(1796f, -164f, 367f, 288f, 0f);
            canvas.RestoreState();


            // View:     rectangleView166
            // NodeName: image 4
            // NodeType: RECTANGLE
            // NodeId:   125:152
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(1796f, -436f, 367f, 288f, 0f);
            canvas.RestoreState();


            // View:     rectangleView167
            // NodeName: image 3
            // NodeType: RECTANGLE
            // NodeId:   125:153
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(1796f, -708f, 367f, 288f, 0f);
            canvas.RestoreState();


            // View:     rectangleView168
            // NodeName: Headtext
            // NodeType: RECTANGLE
            // NodeId:   125:154
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(167, 167, 167);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1811f, -589f, 126f, 21f, 0f);
            canvas.RestoreState();


            // View:     textView26
            // NodeName: Recommended products
            // NodeType: TEXT
            // NodeId:   125:155
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(81, 81, 81);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 24f;
            canvas.DrawString(@"Recommended products", 1806f, -279f, 260f, 19f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     rectangleView169
            // NodeName: Rectangle 5
            // NodeType: RECTANGLE
            // NodeId:   125:196
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(255, 255, 255);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1804f, -637f, 352f, 41f, 29f);
            canvas.StrokeColor = Color.FromRgb(197, 197, 197);
            canvas.Alpha = 1;
            canvas.StrokeSize = 1;
            canvas.DrawRoundedRectangle(1804f, -637f, 352f, 41f, 29f);
            canvas.RestoreState();


            // View:     rectangleView170
            // NodeName: lupa 3
            // NodeType: RECTANGLE
            // NodeId:   125:197
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(2127f, -626f, 18f, 18f, 0f);
            canvas.RestoreState();


            // View:     rectangleView171
            // NodeName: lupa 2
            // NodeType: RECTANGLE
            // NodeId:   125:198
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(2098f, -624f, 17f, 15f, 0f);
            canvas.RestoreState();


            // View:     rectangleView172
            // NodeName: Rectangle 18
            // NodeType: RECTANGLE
            // NodeId:   125:199
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(2092f, -636f, 1f, 39f, 0f);
            canvas.RestoreState();


            // View:     textView27
            // NodeName: Subscribing, pr...
            // NodeType: TEXT
            // NodeId:   125:200
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(81, 81, 81);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 14f;
            canvas.DrawString(@"Subscribing, pr...", 1823f, -626f, 121f, 12f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     rectangleView173
            // NodeName: Navbar
            // NodeType: RECTANGLE
            // NodeId:   125:201
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1785f, 56f, 390f, 91f, 0f);
            canvas.RestoreState();


            // View:     rectangleView174
            // NodeName: image 6
            // NodeType: RECTANGLE
            // NodeId:   125:202
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(1824f, 82f, 39f, 39f, 0f);
            canvas.RestoreState();


            // View:     rectangleView175
            // NodeName: home 1
            // NodeType: RECTANGLE
            // NodeId:   125:203
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(1817f, 76f, 59f, 59f, 0f);
            canvas.RestoreState();


            // View:     rectangleView176
            // NodeName: shop 1
            // NodeType: RECTANGLE
            // NodeId:   125:204
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(1989f, 78f, 58f, 54f, 0f);
            canvas.RestoreState();


            // View:     rectangleView177
            // NodeName: Rectangle 21
            // NodeType: RECTANGLE
            // NodeId:   125:205
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1924f, -173f, 110f, 92f, 0f);
            canvas.RestoreState();


            // View:     rectangleView178
            // NodeName: Rectangle 22
            // NodeType: RECTANGLE
            // NodeId:   125:206
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(2046f, -173f, 110f, 92f, 0f);
            canvas.RestoreState();


            // View:     rectangleView179
            // NodeName: Rectangle 23
            // NodeType: RECTANGLE
            // NodeId:   125:207
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1924f, -62f, 110f, 92f, 0f);
            canvas.RestoreState();


            // View:     textView28
            // NodeName: 1
            // NodeType: TEXT
            // NodeId:   125:208
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(81, 81, 81);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 32f;
            canvas.DrawString(@"1", 1974f, -146f, 12f, 39f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     textView29
            // NodeName: 3
            // NodeType: TEXT
            // NodeId:   125:209
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(81, 81, 81);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 32f;
            canvas.DrawString(@"3", 2091f, -146f, 19f, 39f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     textView30
            // NodeName: 6
            // NodeType: TEXT
            // NodeId:   125:210
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(81, 81, 81);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 32f;
            canvas.DrawString(@"6", 1969f, -35f, 20f, 39f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     rectangleView180
            // NodeName: Rectangle 26
            // NodeType: RECTANGLE
            // NodeId:   125:239
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1908f, -173f, 5f, 222f, 2f);
            canvas.RestoreState();


            // View:     rectangleView181
            // NodeName: Rectangle 24
            // NodeType: RECTANGLE
            // NodeId:   125:212
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(167, 167, 167);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1907f, -173f, 7f, 192f, 4f);
            canvas.RestoreState();


            // View:     textView31
            // NodeName: Subscribing
            // NodeType: TEXT
            // NodeId:   125:213
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(66, 66, 66);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 14f;
            canvas.DrawString(@"Subscribing", 1806f, -173f, 85f, 17f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     textView32
            // NodeName: Advertisement
            // NodeType: TEXT
            // NodeId:   125:214
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(81, 81, 81);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 24f;
            canvas.DrawString(@"Advertisement", 1806f, -562f, 182f, 29f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     rectangleView182
            // NodeName: Rectangle 25
            // NodeType: RECTANGLE
            // NodeId:   125:215
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1807f, -497f, 349f, 198f, 0f);
            canvas.RestoreState();


            // View:     textView33
            // NodeName: Other
            // NodeType: TEXT
            // NodeId:   125:233
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(81, 81, 81);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 14f;
            canvas.DrawString(@"Other", 1806f, -146f, 42f, 17f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     rectangleView183
            // NodeName: image 7
            // NodeType: RECTANGLE
            // NodeId:   125:237
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(1807f, -497f, 349f, 197f, 0f);
            canvas.StrokeColor = Color.FromRgb(87, 87, 87);
            canvas.Alpha = 1;
            canvas.StrokeSize = 1;
            canvas.DrawRoundedRectangle(1807f, -497f, 349f, 197f, 0f);
            canvas.RestoreState();


            // View:     rectangleView184
            // NodeName: Rectangle 27
            // NodeType: RECTANGLE
            // NodeId:   125:240
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(81, 81, 81);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1806f, -524f, 109f, 4f, 4f);
            canvas.RestoreState();


            // View:     rectangleView185
            // NodeName: Rectangle 28
            // NodeType: RECTANGLE
            // NodeId:   125:241
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(81, 81, 81);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(1807f, -208f, 109f, 4f, 4f);
            canvas.RestoreState();


            // View:     frameView32
            // NodeName: New_test
            // NodeType: FRAME
            // NodeId:   125:242
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(255, 255, 255);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(2215f, -697f, 390f, 844f, 0f);
            canvas.RestoreState();


            // View:     rectangleView186
            // NodeName: image 5
            // NodeType: RECTANGLE
            // NodeId:   125:243
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(2226f, -164f, 367f, 288f, 0f);
            canvas.RestoreState();


            // View:     rectangleView187
            // NodeName: image 4
            // NodeType: RECTANGLE
            // NodeId:   125:244
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(2226f, -436f, 367f, 288f, 0f);
            canvas.RestoreState();


            // View:     rectangleView188
            // NodeName: image 3
            // NodeType: RECTANGLE
            // NodeId:   125:245
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(2226f, -708f, 367f, 288f, 0f);
            canvas.RestoreState();


            // View:     rectangleView189
            // NodeName: Headtext
            // NodeType: RECTANGLE
            // NodeId:   125:246
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(167, 167, 167);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(2241f, -589f, 126f, 21f, 0f);
            canvas.RestoreState();


            // View:     rectangleView190
            // NodeName: Navbar
            // NodeType: RECTANGLE
            // NodeId:   125:253
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(2215f, 56f, 390f, 91f, 0f);
            canvas.RestoreState();


            // View:     rectangleView191
            // NodeName: image 6
            // NodeType: RECTANGLE
            // NodeId:   125:254
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(2254f, 82f, 39f, 39f, 0f);
            canvas.RestoreState();


            // View:     rectangleView192
            // NodeName: home 1
            // NodeType: RECTANGLE
            // NodeId:   125:255
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(2247f, 76f, 59f, 59f, 0f);
            canvas.RestoreState();


            // View:     rectangleView193
            // NodeName: shop 1
            // NodeType: RECTANGLE
            // NodeId:   125:256
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(2419f, 78f, 58f, 54f, 0f);
            canvas.RestoreState();


            // View:     textView34
            // NodeName: Make your own
            // NodeType: TEXT
            // NodeId:   125:266
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(81, 81, 81);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 24f;
            canvas.DrawString(@"Make your own", 2316f, -632f, 187f, 29f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     rectangleView194
            // NodeName: Rectangle 27
            // NodeType: RECTANGLE
            // NodeId:   125:270
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(81, 81, 81);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(2355f, -590f, 109f, 4f, 4f);
            canvas.RestoreState();


            // View:     rectangleView195
            // NodeName: Rectangle 29
            // NodeType: RECTANGLE
            // NodeId:   125:272
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(2405f, -384f, 9f, 123f, 4f);
            canvas.RestoreState();


            // View:     rectangleView196
            // NodeName: Rectangle 30
            // NodeType: RECTANGLE
            // NodeId:   125:273
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(2348f, -327f, 123f, 9f, 4f);
            canvas.RestoreState();


            // View:     elipseView5
            // NodeName: Ellipse 2
            // NodeType: ELLIPSE
            // NodeId:   125:275
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillEllipse(2237f, -23f, 19f, 17f);
            canvas.RestoreState();


            // View:     textView35
            // NodeName: i
            // NodeType: TEXT
            // NodeId:   125:276
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(81, 81, 81);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 13f;
            canvas.DrawString(@"i", 2245f, -23f, 4f, 16f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     textView36
            // NodeName: Here you can create your own quiz to test yourself or help others test themselves. But before you should watch 3 videos.
            // NodeType: TEXT
            // NodeId:   125:277
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(81, 81, 81);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 13f;
            canvas.DrawString(@"Here you can create your own quiz to test yourself or help others test themselves. But before you should watch 3 videos.", 2268f, -23f, 315f, 48f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     rectangleView197
            // NodeName: Rectangle 29
            // NodeType: RECTANGLE
            // NodeId:   125:278
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(81, 81, 81);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(2237f, -47f, 109f, 4f, 4f);
            canvas.RestoreState();


            // View:     textView37
            // NodeName: Notice
            // NodeType: TEXT
            // NodeId:   125:279
            canvas.SaveState();
            canvas.FontColor = Color.FromRgb(81, 81, 81);
            canvas.Alpha = 1;
            canvas.Font = new Microsoft.Maui.Graphics.Font("MontserratRoman-Medium", 500, FontStyleType.Normal);
            canvas.FontSize = 24f;
            canvas.DrawString(@"Notice", 2237f, -86f, 80f, 29f, HorizontalAlignment.Left, VerticalAlignment.Top);
            canvas.RestoreState();


            // View:     frameView33
            // NodeName: User_profile
            // NodeType: FRAME
            // NodeId:   125:280
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(255, 255, 255);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(2645f, -697f, 390f, 844f, 0f);
            canvas.RestoreState();


            // View:     rectangleView198
            // NodeName: image 5
            // NodeType: RECTANGLE
            // NodeId:   125:281
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(2656f, -164f, 367f, 288f, 0f);
            canvas.RestoreState();


            // View:     rectangleView199
            // NodeName: image 4
            // NodeType: RECTANGLE
            // NodeId:   125:282
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(2656f, -436f, 367f, 288f, 0f);
            canvas.RestoreState();


            // View:     rectangleView200
            // NodeName: image 3
            // NodeType: RECTANGLE
            // NodeId:   125:283
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(2656f, -708f, 367f, 288f, 0f);
            canvas.RestoreState();


            // View:     rectangleView201
            // NodeName: Headtext
            // NodeType: RECTANGLE
            // NodeId:   125:284
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(167, 167, 167);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(2671f, -589f, 126f, 21f, 0f);
            canvas.RestoreState();


            // View:     rectangleView202
            // NodeName: Navbar
            // NodeType: RECTANGLE
            // NodeId:   125:285
            canvas.SaveState();
            canvas.FillColor = Color.FromRgb(217, 217, 217);
            canvas.Alpha = 1;
            canvas.FillRoundedRectangle(2645f, 56f, 390f, 91f, 0f);
            canvas.RestoreState();


            // View:     rectangleView203
            // NodeName: image 6
            // NodeType: RECTANGLE
            // NodeId:   125:286
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(2684f, 82f, 39f, 39f, 0f);
            canvas.RestoreState();


            // View:     rectangleView204
            // NodeName: home 1
            // NodeType: RECTANGLE
            // NodeId:   125:287
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(2677f, 76f, 59f, 59f, 0f);
            canvas.RestoreState();


            // View:     rectangleView205
            // NodeName: shop 1
            // NodeType: RECTANGLE
            // NodeId:   125:288
            canvas.SaveState();
            canvas.FillColor = Colors.White;
            canvas.FillRoundedRectangle(2849f, 78f, 58f, 54f, 0f);
            canvas.RestoreState();
        }
    }
}