using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Windows.Forms;
using AramaM0t0ru.Properties;
using System.Media;

namespace AramaM0t0ru
{
	public partial class Form1 : Form
	{
		public Form1()
		{
			this.InitializeComponent();
		}

		int mov;
		int movX;
		int movY;

		public void deneme()
		{
			Uri requestUri = new Uri("http://www.google.com.tr");
			WebRequest webRequest = WebRequest.Create(requestUri);
			try
			{
				WebResponse response = webRequest.GetResponse();
				response.Close();
				this.a1 = true;
			}
			catch
			{
				this.a1 = false;
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.aList.Add("www.com");
			this.aList.Add("www.net");
			this.aList.Add("www.nato");
			this.aList.Add("www.ad");
			this.aList.Add("www.ae");
			this.aList.Add("www.af");
			this.aList.Add("www.ag");
			this.aList.Add("www.ai");
			this.aList.Add("www.al");
			this.aList.Add("www.am");
			this.aList.Add("www.an");
			this.aList.Add("www.ao");
			this.aList.Add("www.arpa");
			this.aList.Add("www.ar");
			this.aList.Add("www.as");
			this.aList.Add("www.at");
			this.aList.Add("www.au");
			this.aList.Add("www.aw");
			this.aList.Add("www.az");
			this.aList.Add("www.a");
			this.aList.Add("www.ba");
			this.aList.Add("www.bb");
			this.aList.Add("www.bd");
			this.aList.Add("www.be");
			this.aList.Add("www.bf");
			this.aList.Add("www.bg");
			this.aList.Add("www.bh");
			this.aList.Add("www.biz");
			this.aList.Add("www.bi");
			this.aList.Add("www.bj");
			this.aList.Add("www.bm");
			this.aList.Add("www.bn");
			this.aList.Add("www.bo");
			this.aList.Add("www.br");
			this.aList.Add("www.bs");
			this.aList.Add("www.bt");
			this.aList.Add("www.bv");
			this.aList.Add("www.bw");
			this.aList.Add("www.by");
			this.aList.Add("www.bz");
			this.aList.Add("www.ca");
			this.aList.Add("www.cc");
			this.aList.Add("www.cf");
			this.aList.Add("www.cg");
			this.aList.Add("www.ch");
			this.aList.Add("www.ci");
			this.aList.Add("www.ck");
			this.aList.Add("www.cl");
			this.aList.Add("www.cm");
			this.aList.Add("www.cn");
			this.aList.Add("www.co");
			this.aList.Add("www.cr");
			this.aList.Add("www.cs");
			this.aList.Add("www.cu");
			this.aList.Add("www.cv");
			this.aList.Add("www.cx");
			this.aList.Add("www.cy");
			this.aList.Add("www.cz");
			this.aList.Add("www.de");
			this.aList.Add("www.dj");
			this.aList.Add("www.dk");
			this.aList.Add("www.dm");
			this.aList.Add("www.do");
			this.aList.Add("www.dz");
			this.aList.Add("www.ec");
			this.aList.Add("www.edu");
			this.aList.Add("www.ee");
			this.aList.Add("www.eg");
			this.aList.Add("www.eh");
			this.aList.Add("www.er");
			this.aList.Add("www.es");
			this.aList.Add("www.et");
			this.aList.Add("www.fi");
			this.aList.Add("www.fj");
			this.aList.Add("www.fk");
			this.aList.Add("www.fm");
			this.aList.Add("www.fo");
			this.aList.Add("www.fr");
			this.aList.Add("www.fx");
			this.aList.Add("www.ga");
			this.aList.Add("www.gb");
			this.aList.Add("www.gd");
			this.aList.Add("www.ge");
			this.aList.Add("www.gf");
			this.aList.Add("www.gh");
			this.aList.Add("www.gi");
			this.aList.Add("www.gl");
			this.aList.Add("www.gm");
			this.aList.Add("www.gn");
			this.aList.Add("www.gov");
			this.aList.Add("www.gp");
			this.aList.Add("www.gq");
			this.aList.Add("www.gr");
			this.aList.Add("www.gs");
			this.aList.Add("www.gt");
			this.aList.Add("www.gu");
			this.aList.Add("www.gw");
			this.aList.Add("www.gy");
			this.aList.Add("www.hk");
			this.aList.Add("www.hm");
			this.aList.Add("www.hn");
			this.aList.Add("www.hr");
			this.aList.Add("www.ht");
			this.aList.Add("www.hu");
			this.aList.Add("www.id");
			this.aList.Add("www.ie");
			this.aList.Add("www.il");
			this.aList.Add("www.info");
			this.aList.Add("www.int");
			this.aList.Add("www.in");
			this.aList.Add("www.io");
			this.aList.Add("www.iq");
			this.aList.Add("www.ir");
			this.aList.Add("www.is");
			this.aList.Add("www.it");
			this.aList.Add("www.jm");
			this.aList.Add("www.jo");
			this.aList.Add("www.jp");
			this.aList.Add("www.ke");
			this.aList.Add("www.kg");
			this.aList.Add("www.kh");
			this.aList.Add("www.ki");
			this.aList.Add("www.km");
			this.aList.Add("www.kn");
			this.aList.Add("www.kp");
			this.aList.Add("www.kr");
			this.aList.Add("www.kw");
			this.aList.Add("www.ky");
			this.aList.Add("www.kz");
			this.aList.Add("www.la");
			this.aList.Add("www.lb");
			this.aList.Add("www.lc");
			this.aList.Add("www.li");
			this.aList.Add("www.lk");
			this.aList.Add("www.lr");
			this.aList.Add("www.ls");
			this.aList.Add("www.lt");
			this.aList.Add("www.lu");
			this.aList.Add("www.lv");
			this.aList.Add("www.ly");
			this.aList.Add("www.ma");
			this.aList.Add("www.mc");
			this.aList.Add("www.md");
			this.aList.Add("www.mg");
			this.aList.Add("www.mh");
			this.aList.Add("www.mil");
			this.aList.Add("www.mk");
			this.aList.Add("www.ml");
			this.aList.Add("www.mm");
			this.aList.Add("www.mn");
			this.aList.Add("www.mobi");
			this.aList.Add("www.mo");
			this.aList.Add("www.mp");
			this.aList.Add("www.mq");
			this.aList.Add("www.mr");
			this.aList.Add("www.ms");
			this.aList.Add("www.mt");
			this.aList.Add("www.mu");
			this.aList.Add("www.mv");
			this.aList.Add("www.mw");
			this.aList.Add("www.mx");
			this.aList.Add("www.my");
			this.aList.Add("www.mz");
			this.aList.Add("www.na");
			this.aList.Add("www.nc");
			this.aList.Add("www.ne");
			this.aList.Add("www.nf");
			this.aList.Add("www.ng");
			this.aList.Add("www.ni");
			this.aList.Add("www.nl");
			this.aList.Add("www.no");
			this.aList.Add("www.np");
			this.aList.Add("www.nr");
			this.aList.Add("www.nt");
			this.aList.Add("www.nu");
			this.aList.Add("www.nz");
			this.aList.Add("www.om");
			this.aList.Add("www.org");
			this.aList.Add("www.pa");
			this.aList.Add("www.pe");
			this.aList.Add("www.pf");
			this.aList.Add("www.pg");
			this.aList.Add("www.ph");
			this.aList.Add("www.pk");
			this.aList.Add("www.pl");
			this.aList.Add("www.pm");
			this.aList.Add("www.pn");
			this.aList.Add("www.pr");
			this.aList.Add("www.pt");
			this.aList.Add("www.pw");
			this.aList.Add("www.py");
			this.aList.Add("www.qa");
			this.aList.Add("www.re");
			this.aList.Add("www.ro");
			this.aList.Add("www.ru");
			this.aList.Add("www.rw");
			this.aList.Add("www.sa");
			this.aList.Add("www.sb");
			this.aList.Add("www.sc");
			this.aList.Add("www.sd");
			this.aList.Add("www.se");
			this.aList.Add("www.sg");
			this.aList.Add("www.sh");
			this.aList.Add("www.si");
			this.aList.Add("www.sj");
			this.aList.Add("www.sk");
			this.aList.Add("www.sl");
			this.aList.Add("www.sm");
			this.aList.Add("www.sn");
			this.aList.Add("www.so");
			this.aList.Add("www.sr");
			this.aList.Add("www.st");
			this.aList.Add("www.su");
			this.aList.Add("www.sv");
			this.aList.Add("www.sy");
			this.aList.Add("www.sz");
			this.aList.Add("www.tc");
			this.aList.Add("www.td");
			this.aList.Add("www.tf");
			this.aList.Add("www.tg");
			this.aList.Add("www.th");
			this.aList.Add("www.tj");
			this.aList.Add("www.tk");
			this.aList.Add("www.tm");
			this.aList.Add("www.tn");
			this.aList.Add("www.to");
			this.aList.Add("www.tp");
			this.aList.Add("www.tr");
			this.aList.Add("www.tt");
			this.aList.Add("www.tv");
			this.aList.Add("www.tw");
			this.aList.Add("www.tz");
			this.aList.Add("www.ua");
			this.aList.Add("www.ug");
			this.aList.Add("www.uk");
			this.aList.Add("www.um");
			this.aList.Add("www.us");
			this.aList.Add("www.uy");
			this.aList.Add("www.uz");
			this.aList.Add("www.va");
			this.aList.Add("www.vc");
			this.aList.Add("www.ve");
			this.aList.Add("www.vg");
			this.aList.Add("www.vi");
			this.aList.Add("www.vn");
			this.aList.Add("www.vu");
			this.aList.Add("www.wf");
			this.aList.Add("www.ws");
			this.aList.Add("www.ye");
			this.aList.Add("www.yt");
			this.aList.Add("www.yu");
			this.aList.Add("www.za");
			this.aList.Add("www.zm");
			this.aList.Add("www.zr");
			this.aList.Add("www.zw");
			this.aList.Add("www.com/");
			this.aList.Add("www.net/");
			this.aList.Add("www.nato/");
			this.aList.Add("www.ad/");
			this.aList.Add("www.ae/");
			this.aList.Add("www.af/");
			this.aList.Add("www.ag/");
			this.aList.Add("www.ai/");
			this.aList.Add("www.al/");
			this.aList.Add("www.am/");
			this.aList.Add("www.an/");
			this.aList.Add("www.ao/");
			this.aList.Add("www.arpa/");
			this.aList.Add("www.ar/");
			this.aList.Add("www.as/");
			this.aList.Add("www.at/");
			this.aList.Add("www.au/");
			this.aList.Add("www.aw/");
			this.aList.Add("www.az/");
			this.aList.Add("www.a/");
			this.aList.Add("www.ba/");
			this.aList.Add("www.bb/");
			this.aList.Add("www.bd/");
			this.aList.Add("www.be/");
			this.aList.Add("www.bf/");
			this.aList.Add("www.bg/");
			this.aList.Add("www.bh/");
			this.aList.Add("www.biz/");
			this.aList.Add("www.bi/");
			this.aList.Add("www.bj/");
			this.aList.Add("www.bm/");
			this.aList.Add("www.bn/");
			this.aList.Add("www.bo/");
			this.aList.Add("www.br/");
			this.aList.Add("www.bs/");
			this.aList.Add("www.bt/");
			this.aList.Add("www.bv/");
			this.aList.Add("www.bw/");
			this.aList.Add("www.by/");
			this.aList.Add("www.bz/");
			this.aList.Add("www.ca/");
			this.aList.Add("www.cc/");
			this.aList.Add("www.cf/");
			this.aList.Add("www.cg/");
			this.aList.Add("www.ch/");
			this.aList.Add("www.ci/");
			this.aList.Add("www.ck/");
			this.aList.Add("www.cl/");
			this.aList.Add("www.cm/");
			this.aList.Add("www.cn/");
			this.aList.Add("www.co/");
			this.aList.Add("www.cr/");
			this.aList.Add("www.cs/");
			this.aList.Add("www.cu/");
			this.aList.Add("www.cv/");
			this.aList.Add("www.cx/");
			this.aList.Add("www.cy/");
			this.aList.Add("www.cz/");
			this.aList.Add("www.de/");
			this.aList.Add("www.dj/");
			this.aList.Add("www.dk/");
			this.aList.Add("www.dm/");
			this.aList.Add("www.do/");
			this.aList.Add("www.dz/");
			this.aList.Add("www.ec/");
			this.aList.Add("www.edu/");
			this.aList.Add("www.ee/");
			this.aList.Add("www.eg/");
			this.aList.Add("www.eh/");
			this.aList.Add("www.er/");
			this.aList.Add("www.es/");
			this.aList.Add("www.et/");
			this.aList.Add("www.fi/");
			this.aList.Add("www.fj/");
			this.aList.Add("www.fk/");
			this.aList.Add("www.fm/");
			this.aList.Add("www.fo/");
			this.aList.Add("www.fr/");
			this.aList.Add("www.fx/");
			this.aList.Add("www.ga/");
			this.aList.Add("www.gb/");
			this.aList.Add("www.gd/");
			this.aList.Add("www.ge/");
			this.aList.Add("www.gf/");
			this.aList.Add("www.gh/");
			this.aList.Add("www.gi/");
			this.aList.Add("www.gl/");
			this.aList.Add("www.gm/");
			this.aList.Add("www.gn/");
			this.aList.Add("www.gov/");
			this.aList.Add("www.gp/");
			this.aList.Add("www.gq/");
			this.aList.Add("www.gr/");
			this.aList.Add("www.gs/");
			this.aList.Add("www.gt/");
			this.aList.Add("www.gu/");
			this.aList.Add("www.gw/");
			this.aList.Add("www.gy/");
			this.aList.Add("www.hk/");
			this.aList.Add("www.hm/");
			this.aList.Add("www.hn/");
			this.aList.Add("www.hr/");
			this.aList.Add("www.ht/");
			this.aList.Add("www.hu/");
			this.aList.Add("www.id/");
			this.aList.Add("www.ie/");
			this.aList.Add("www.il/");
			this.aList.Add("www.info/");
			this.aList.Add("www.int/");
			this.aList.Add("www.in/");
			this.aList.Add("www.io/");
			this.aList.Add("www.iq/");
			this.aList.Add("www.ir/");
			this.aList.Add("www.is/");
			this.aList.Add("www.it/");
			this.aList.Add("www.jm/");
			this.aList.Add("www.jo/");
			this.aList.Add("www.jp/");
			this.aList.Add("www.ke/");
			this.aList.Add("www.kg/");
			this.aList.Add("www.kh/");
			this.aList.Add("www.ki/");
			this.aList.Add("www.km/");
			this.aList.Add("www.kn/");
			this.aList.Add("www.kp/");
			this.aList.Add("www.kr/");
			this.aList.Add("www.kw/");
			this.aList.Add("www.ky/");
			this.aList.Add("www.kz/");
			this.aList.Add("www.la/");
			this.aList.Add("www.lb/");
			this.aList.Add("www.lc/");
			this.aList.Add("www.li/");
			this.aList.Add("www.lk/");
			this.aList.Add("www.lr/");
			this.aList.Add("www.ls/");
			this.aList.Add("www.lt/");
			this.aList.Add("www.lu/");
			this.aList.Add("www.lv/");
			this.aList.Add("www.ly/");
			this.aList.Add("www.ma/");
			this.aList.Add("www.mc/");
			this.aList.Add("www.md/");
			this.aList.Add("www.mg/");
			this.aList.Add("www.mh/");
			this.aList.Add("www.mil/");
			this.aList.Add("www.mk/");
			this.aList.Add("www.ml/");
			this.aList.Add("www.mm/");
			this.aList.Add("www.mn/");
			this.aList.Add("www.mobi/");
			this.aList.Add("www.mo/");
			this.aList.Add("www.mp/");
			this.aList.Add("www.mq/");
			this.aList.Add("www.mr/");
			this.aList.Add("www.ms/");
			this.aList.Add("www.mt/");
			this.aList.Add("www.mu/");
			this.aList.Add("www.mv/");
			this.aList.Add("www.mw/");
			this.aList.Add("www.mx/");
			this.aList.Add("www.my/");
			this.aList.Add("www.mz/");
			this.aList.Add("www.na/");
			this.aList.Add("www.nc/");
			this.aList.Add("www.ne/");
			this.aList.Add("www.nf/");
			this.aList.Add("www.ng/");
			this.aList.Add("www.ni/");
			this.aList.Add("www.nl/");
			this.aList.Add("www.no/");
			this.aList.Add("www.np/");
			this.aList.Add("www.nr/");
			this.aList.Add("www.nt/");
			this.aList.Add("www.nu/");
			this.aList.Add("www.nz/");
			this.aList.Add("www.om/");
			this.aList.Add("www.org/");
			this.aList.Add("www.pa/");
			this.aList.Add("www.pe/");
			this.aList.Add("www.pf/");
			this.aList.Add("www.pg/");
			this.aList.Add("www.ph/");
			this.aList.Add("www.pk/");
			this.aList.Add("www.pl/");
			this.aList.Add("www.pm/");
			this.aList.Add("www.pn/");
			this.aList.Add("www.pr/");
			this.aList.Add("www.pt/");
			this.aList.Add("www.pw/");
			this.aList.Add("www.py/");
			this.aList.Add("www.qa/");
			this.aList.Add("www.re/");
			this.aList.Add("www.ro/");
			this.aList.Add("www.ru/");
			this.aList.Add("www.rw/");
			this.aList.Add("www.sa/");
			this.aList.Add("www.sb/");
			this.aList.Add("www.sc/");
			this.aList.Add("www.sd/");
			this.aList.Add("www.se/");
			this.aList.Add("www.sg/");
			this.aList.Add("www.sh/");
			this.aList.Add("www.si/");
			this.aList.Add("www.sj/");
			this.aList.Add("www.sk/");
			this.aList.Add("www.sl/");
			this.aList.Add("www.sm/");
			this.aList.Add("www.sn/");
			this.aList.Add("www.so/");
			this.aList.Add("www.sr/");
			this.aList.Add("www.st/");
			this.aList.Add("www.su/");
			this.aList.Add("www.sv/");
			this.aList.Add("www.sy/");
			this.aList.Add("www.sz/");
			this.aList.Add("www.tc/");
			this.aList.Add("www.td/");
			this.aList.Add("www.tf/");
			this.aList.Add("www.tg/");
			this.aList.Add("www.th/");
			this.aList.Add("www.tj/");
			this.aList.Add("www.tk/");
			this.aList.Add("www.tm/");
			this.aList.Add("www.tn/");
			this.aList.Add("www.to/");
			this.aList.Add("www.tp/");
			this.aList.Add("www.tr/");
			this.aList.Add("www.tt/");
			this.aList.Add("www.tv/");
			this.aList.Add("www.tw/");
			this.aList.Add("www.tz/");
			this.aList.Add("www.ua/");
			this.aList.Add("www.ug/");
			this.aList.Add("www.uk/");
			this.aList.Add("www.um/");
			this.aList.Add("www.us/");
			this.aList.Add("www.uy/");
			this.aList.Add("www.uz/");
			this.aList.Add("www.va/");
			this.aList.Add("www.vc/");
			this.aList.Add("www.ve/");
			this.aList.Add("www.vg/");
			this.aList.Add("www.vi/");
			this.aList.Add("www.vn/");
			this.aList.Add("www.vu/");
			this.aList.Add("www.wf/");
			this.aList.Add("www.ws/");
			this.aList.Add("www.ye/");
			this.aList.Add("www.yt/");
			this.aList.Add("www.yu/");
			this.aList.Add("www.za/");
			this.aList.Add("www.zm/");
			this.aList.Add("www.zr/");
			this.aList.Add("www.zw/");
			this.aList.Add("http://www.com/");
			this.aList.Add("http://www.net/");
			this.aList.Add("http://www.nato/");
			this.aList.Add("http://www.ad/");
			this.aList.Add("http://www.ae/");
			this.aList.Add("http://www.af/");
			this.aList.Add("http://www.ag/");
			this.aList.Add("http://www.ai/");
			this.aList.Add("http://www.al/");
			this.aList.Add("http://www.am/");
			this.aList.Add("http://www.an/");
			this.aList.Add("http://www.ao/");
			this.aList.Add("http://www.arpa/");
			this.aList.Add("http://www.ar/");
			this.aList.Add("http://www.as/");
			this.aList.Add("http://www.at/");
			this.aList.Add("http://www.au/");
			this.aList.Add("http://www.aw/");
			this.aList.Add("http://www.az/");
			this.aList.Add("http://www.a/");
			this.aList.Add("http://www.ba/");
			this.aList.Add("http://www.bb/");
			this.aList.Add("http://www.bd/");
			this.aList.Add("http://www.be/");
			this.aList.Add("http://www.bf/");
			this.aList.Add("http://www.bg/");
			this.aList.Add("http://www.bh/");
			this.aList.Add("http://www.biz/");
			this.aList.Add("http://www.bi/");
			this.aList.Add("http://www.bj/");
			this.aList.Add("http://www.bm/");
			this.aList.Add("http://www.bn/");
			this.aList.Add("http://www.bo/");
			this.aList.Add("http://www.br/");
			this.aList.Add("http://www.bs/");
			this.aList.Add("http://www.bt/");
			this.aList.Add("http://www.bv/");
			this.aList.Add("http://www.bw/");
			this.aList.Add("http://www.by/");
			this.aList.Add("http://www.bz/");
			this.aList.Add("http://www.ca/");
			this.aList.Add("http://www.cc/");
			this.aList.Add("http://www.cf/");
			this.aList.Add("http://www.cg/");
			this.aList.Add("http://www.ch/");
			this.aList.Add("http://www.ci/");
			this.aList.Add("http://www.ck/");
			this.aList.Add("http://www.cl/");
			this.aList.Add("http://www.cm/");
			this.aList.Add("http://www.cn/");
			this.aList.Add("http://www.co/");
			this.aList.Add("http://www.cr/");
			this.aList.Add("http://www.cs/");
			this.aList.Add("http://www.cu/");
			this.aList.Add("http://www.cv/");
			this.aList.Add("http://www.cx/");
			this.aList.Add("http://www.cy/");
			this.aList.Add("http://www.cz/");
			this.aList.Add("http://www.de/");
			this.aList.Add("http://www.dj/");
			this.aList.Add("http://www.dk/");
			this.aList.Add("http://www.dm/");
			this.aList.Add("http://www.do/");
			this.aList.Add("http://www.dz/");
			this.aList.Add("http://www.ec/");
			this.aList.Add("http://www.edu/");
			this.aList.Add("http://www.ee/");
			this.aList.Add("http://www.eg/");
			this.aList.Add("http://www.eh/");
			this.aList.Add("http://www.er/");
			this.aList.Add("http://www.es/");
			this.aList.Add("http://www.et/");
			this.aList.Add("http://www.fi/");
			this.aList.Add("http://www.fj/");
			this.aList.Add("http://www.fk/");
			this.aList.Add("http://www.fm/");
			this.aList.Add("http://www.fo/");
			this.aList.Add("http://www.fr/");
			this.aList.Add("http://www.fx/");
			this.aList.Add("http://www.ga/");
			this.aList.Add("http://www.gb/");
			this.aList.Add("http://www.gd/");
			this.aList.Add("http://www.ge/");
			this.aList.Add("http://www.gf/");
			this.aList.Add("http://www.gh/");
			this.aList.Add("http://www.gi/");
			this.aList.Add("http://www.gl/");
			this.aList.Add("http://www.gm/");
			this.aList.Add("http://www.gn/");
			this.aList.Add("http://www.gov/");
			this.aList.Add("http://www.gp/");
			this.aList.Add("http://www.gq/");
			this.aList.Add("http://www.gr/");
			this.aList.Add("http://www.gs/");
			this.aList.Add("http://www.gt/");
			this.aList.Add("http://www.gu/");
			this.aList.Add("http://www.gw/");
			this.aList.Add("http://www.gy/");
			this.aList.Add("http://www.hk/");
			this.aList.Add("http://www.hm/");
			this.aList.Add("http://www.hn/");
			this.aList.Add("http://www.hr/");
			this.aList.Add("http://www.ht/");
			this.aList.Add("http://www.hu/");
			this.aList.Add("http://www.id/");
			this.aList.Add("http://www.ie/");
			this.aList.Add("http://www.il/");
			this.aList.Add("http://www.info/");
			this.aList.Add("http://www.int/");
			this.aList.Add("http://www.in/");
			this.aList.Add("http://www.io/");
			this.aList.Add("http://www.iq/");
			this.aList.Add("http://www.ir/");
			this.aList.Add("http://www.is/");
			this.aList.Add("http://www.it/");
			this.aList.Add("http://www.jm/");
			this.aList.Add("http://www.jo/");
			this.aList.Add("http://www.jp/");
			this.aList.Add("http://www.ke/");
			this.aList.Add("http://www.kg/");
			this.aList.Add("http://www.kh/");
			this.aList.Add("http://www.ki/");
			this.aList.Add("http://www.km/");
			this.aList.Add("http://www.kn/");
			this.aList.Add("http://www.kp/");
			this.aList.Add("http://www.kr/");
			this.aList.Add("http://www.kw/");
			this.aList.Add("http://www.ky/");
			this.aList.Add("http://www.kz/");
			this.aList.Add("http://www.la/");
			this.aList.Add("http://www.lb/");
			this.aList.Add("http://www.lc/");
			this.aList.Add("http://www.li/");
			this.aList.Add("http://www.lk/");
			this.aList.Add("http://www.lr/");
			this.aList.Add("http://www.ls/");
			this.aList.Add("http://www.lt/");
			this.aList.Add("http://www.lu/");
			this.aList.Add("http://www.lv/");
			this.aList.Add("http://www.ly/");
			this.aList.Add("http://www.ma/");
			this.aList.Add("http://www.mc/");
			this.aList.Add("http://www.md/");
			this.aList.Add("http://www.mg/");
			this.aList.Add("http://www.mh/");
			this.aList.Add("http://www.mil/");
			this.aList.Add("http://www.mk/");
			this.aList.Add("http://www.ml/");
			this.aList.Add("http://www.mm/");
			this.aList.Add("http://www.mn/");
			this.aList.Add("http://www.mobi/");
			this.aList.Add("http://www.mo/");
			this.aList.Add("http://www.mp/");
			this.aList.Add("http://www.mq/");
			this.aList.Add("http://www.mr/");
			this.aList.Add("http://www.ms/");
			this.aList.Add("http://www.mt/");
			this.aList.Add("http://www.mu/");
			this.aList.Add("http://www.mv/");
			this.aList.Add("http://www.mw/");
			this.aList.Add("http://www.mx/");
			this.aList.Add("http://www.my/");
			this.aList.Add("http://www.mz/");
			this.aList.Add("http://www.na/");
			this.aList.Add("http://www.nc/");
			this.aList.Add("http://www.ne/");
			this.aList.Add("http://www.nf/");
			this.aList.Add("http://www.ng/");
			this.aList.Add("http://www.ni/");
			this.aList.Add("http://www.nl/");
			this.aList.Add("http://www.no/");
			this.aList.Add("http://www.np/");
			this.aList.Add("http://www.nr/");
			this.aList.Add("http://www.nt/");
			this.aList.Add("http://www.nu/");
			this.aList.Add("http://www.nz/");
			this.aList.Add("http://www.om/");
			this.aList.Add("http://www.org/");
			this.aList.Add("http://www.pa/");
			this.aList.Add("http://www.pe/");
			this.aList.Add("http://www.pf/");
			this.aList.Add("http://www.pg/");
			this.aList.Add("http://www.ph/");
			this.aList.Add("http://www.pk/");
			this.aList.Add("http://www.pl/");
			this.aList.Add("http://www.pm/");
			this.aList.Add("http://www.pn/");
			this.aList.Add("http://www.pr/");
			this.aList.Add("http://www.pt/");
			this.aList.Add("http://www.pw/");
			this.aList.Add("http://www.py/");
			this.aList.Add("http://www.qa/");
			this.aList.Add("http://www.re/");
			this.aList.Add("http://www.ro/");
			this.aList.Add("http://www.ru/");
			this.aList.Add("http://www.rw/");
			this.aList.Add("http://www.sa/");
			this.aList.Add("http://www.sb/");
			this.aList.Add("http://www.sc/");
			this.aList.Add("http://www.sd/");
			this.aList.Add("http://www.se/");
			this.aList.Add("http://www.sg/");
			this.aList.Add("http://www.sh/");
			this.aList.Add("http://www.si/");
			this.aList.Add("http://www.sj/");
			this.aList.Add("http://www.sk/");
			this.aList.Add("http://www.sl/");
			this.aList.Add("http://www.sm/");
			this.aList.Add("http://www.sn/");
			this.aList.Add("http://www.so/");
			this.aList.Add("http://www.sr/");
			this.aList.Add("http://www.st/");
			this.aList.Add("http://www.su/");
			this.aList.Add("http://www.sv/");
			this.aList.Add("http://www.sy/");
			this.aList.Add("http://www.sz/");
			this.aList.Add("http://www.tc/");
			this.aList.Add("http://www.td/");
			this.aList.Add("http://www.tf/");
			this.aList.Add("http://www.tg/");
			this.aList.Add("http://www.th/");
			this.aList.Add("http://www.tj/");
			this.aList.Add("http://www.tk/");
			this.aList.Add("http://www.tm/");
			this.aList.Add("http://www.tn/");
			this.aList.Add("http://www.to/");
			this.aList.Add("http://www.tp/");
			this.aList.Add("http://www.tr/");
			this.aList.Add("http://www.tt/");
			this.aList.Add("http://www.tv/");
			this.aList.Add("http://www.tw/");
			this.aList.Add("http://www.tz/");
			this.aList.Add("http://www.ua/");
			this.aList.Add("http://www.ug/");
			this.aList.Add("http://www.uk/");
			this.aList.Add("http://www.um/");
			this.aList.Add("http://www.us/");
			this.aList.Add("http://www.uy/");
			this.aList.Add("http://www.uz/");
			this.aList.Add("http://www.va/");
			this.aList.Add("http://www.vc/");
			this.aList.Add("http://www.ve/");
			this.aList.Add("http://www.vg/");
			this.aList.Add("http://www.vi/");
			this.aList.Add("http://www.vn/");
			this.aList.Add("http://www.vu/");
			this.aList.Add("http://www.wf/");
			this.aList.Add("http://www.ws/");
			this.aList.Add("http://www.ye/");
			this.aList.Add("http://www.yt/");
			this.aList.Add("http://www.yu/");
			this.aList.Add("http://www.za/");
			this.aList.Add("http://www.zm/");
			this.aList.Add("http://www.zr/");
			this.aList.Add("http://www.zw/");
			this.aList.Add("http://www.com");
			this.aList.Add("http://www.net");
			this.aList.Add("http://www.nato");
			this.aList.Add("http://www.ad");
			this.aList.Add("http://www.ae");
			this.aList.Add("http://www.af");
			this.aList.Add("http://www.ag");
			this.aList.Add("http://www.ai");
			this.aList.Add("http://www.al");
			this.aList.Add("http://www.am");
			this.aList.Add("http://www.an");
			this.aList.Add("http://www.ao");
			this.aList.Add("http://www.arpa");
			this.aList.Add("http://www.ar");
			this.aList.Add("http://www.as");
			this.aList.Add("http://www.at");
			this.aList.Add("http://www.au");
			this.aList.Add("http://www.aw");
			this.aList.Add("http://www.az");
			this.aList.Add("http://www.a");
			this.aList.Add("http://www.ba");
			this.aList.Add("http://www.bb");
			this.aList.Add("http://www.bd");
			this.aList.Add("http://www.be");
			this.aList.Add("http://www.bf");
			this.aList.Add("http://www.bg");
			this.aList.Add("http://www.bh");
			this.aList.Add("http://www.biz");
			this.aList.Add("http://www.bi");
			this.aList.Add("http://www.bj");
			this.aList.Add("http://www.bm");
			this.aList.Add("http://www.bn");
			this.aList.Add("http://www.bo");
			this.aList.Add("http://www.br");
			this.aList.Add("http://www.bs");
			this.aList.Add("http://www.bt");
			this.aList.Add("http://www.bv");
			this.aList.Add("http://www.bw");
			this.aList.Add("http://www.by");
			this.aList.Add("http://www.bz");
			this.aList.Add("http://www.ca");
			this.aList.Add("http://www.cc");
			this.aList.Add("http://www.cf");
			this.aList.Add("http://www.cg");
			this.aList.Add("http://www.ch");
			this.aList.Add("http://www.ci");
			this.aList.Add("http://www.ck");
			this.aList.Add("http://www.cl");
			this.aList.Add("http://www.cm");
			this.aList.Add("http://www.cn");
			this.aList.Add("http://www.co");
			this.aList.Add("http://www.cr");
			this.aList.Add("http://www.cs");
			this.aList.Add("http://www.cu");
			this.aList.Add("http://www.cv");
			this.aList.Add("http://www.cx");
			this.aList.Add("http://www.cy");
			this.aList.Add("http://www.cz");
			this.aList.Add("http://www.de");
			this.aList.Add("http://www.dj");
			this.aList.Add("http://www.dk");
			this.aList.Add("http://www.dm");
			this.aList.Add("http://www.do");
			this.aList.Add("http://www.dz");
			this.aList.Add("http://www.ec");
			this.aList.Add("http://www.edu");
			this.aList.Add("http://www.ee");
			this.aList.Add("http://www.eg");
			this.aList.Add("http://www.eh");
			this.aList.Add("http://www.er");
			this.aList.Add("http://www.es");
			this.aList.Add("http://www.et");
			this.aList.Add("http://www.fi");
			this.aList.Add("http://www.fj");
			this.aList.Add("http://www.fk");
			this.aList.Add("http://www.fm");
			this.aList.Add("http://www.fo");
			this.aList.Add("http://www.fr");
			this.aList.Add("http://www.fx");
			this.aList.Add("http://www.ga");
			this.aList.Add("http://www.gb");
			this.aList.Add("http://www.gd");
			this.aList.Add("http://www.ge");
			this.aList.Add("http://www.gf");
			this.aList.Add("http://www.gh");
			this.aList.Add("http://www.gi");
			this.aList.Add("http://www.gl");
			this.aList.Add("http://www.gm");
			this.aList.Add("http://www.gn");
			this.aList.Add("http://www.gov");
			this.aList.Add("http://www.gp");
			this.aList.Add("http://www.gq");
			this.aList.Add("http://www.gr");
			this.aList.Add("http://www.gs");
			this.aList.Add("http://www.gt");
			this.aList.Add("http://www.gu");
			this.aList.Add("http://www.gw");
			this.aList.Add("http://www.gy");
			this.aList.Add("http://www.hk");
			this.aList.Add("http://www.hm");
			this.aList.Add("http://www.hn");
			this.aList.Add("http://www.hr");
			this.aList.Add("http://www.ht");
			this.aList.Add("http://www.hu");
			this.aList.Add("http://www.id");
			this.aList.Add("http://www.ie");
			this.aList.Add("http://www.il");
			this.aList.Add("http://www.info");
			this.aList.Add("http://www.int");
			this.aList.Add("http://www.in");
			this.aList.Add("http://www.io");
			this.aList.Add("http://www.iq");
			this.aList.Add("http://www.ir");
			this.aList.Add("http://www.is");
			this.aList.Add("http://www.it");
			this.aList.Add("http://www.jm");
			this.aList.Add("http://www.jo");
			this.aList.Add("http://www.jp");
			this.aList.Add("http://www.ke");
			this.aList.Add("http://www.kg");
			this.aList.Add("http://www.kh");
			this.aList.Add("http://www.ki");
			this.aList.Add("http://www.km");
			this.aList.Add("http://www.kn");
			this.aList.Add("http://www.kp");
			this.aList.Add("http://www.kr");
			this.aList.Add("http://www.kw");
			this.aList.Add("http://www.ky");
			this.aList.Add("http://www.kz");
			this.aList.Add("http://www.la");
			this.aList.Add("http://www.lb");
			this.aList.Add("http://www.lc");
			this.aList.Add("http://www.li");
			this.aList.Add("http://www.lk");
			this.aList.Add("http://www.lr");
			this.aList.Add("http://www.ls");
			this.aList.Add("http://www.lt");
			this.aList.Add("http://www.lu");
			this.aList.Add("http://www.lv");
			this.aList.Add("http://www.ly");
			this.aList.Add("http://www.ma");
			this.aList.Add("http://www.mc");
			this.aList.Add("http://www.md");
			this.aList.Add("http://www.mg");
			this.aList.Add("http://www.mh");
			this.aList.Add("http://www.mil");
			this.aList.Add("http://www.mk");
			this.aList.Add("http://www.ml");
			this.aList.Add("http://www.mm");
			this.aList.Add("http://www.mn");
			this.aList.Add("http://www.mobi");
			this.aList.Add("http://www.mo");
			this.aList.Add("http://www.mp");
			this.aList.Add("http://www.mq");
			this.aList.Add("http://www.mr");
			this.aList.Add("http://www.ms");
			this.aList.Add("http://www.mt");
			this.aList.Add("http://www.mu");
			this.aList.Add("http://www.mv");
			this.aList.Add("http://www.mw");
			this.aList.Add("http://www.mx");
			this.aList.Add("http://www.my");
			this.aList.Add("http://www.mz");
			this.aList.Add("http://www.na");
			this.aList.Add("http://www.nc");
			this.aList.Add("http://www.ne");
			this.aList.Add("http://www.nf");
			this.aList.Add("http://www.ng");
			this.aList.Add("http://www.ni");
			this.aList.Add("http://www.nl");
			this.aList.Add("http://www.no");
			this.aList.Add("http://www.np");
			this.aList.Add("http://www.nr");
			this.aList.Add("http://www.nt");
			this.aList.Add("http://www.nu");
			this.aList.Add("http://www.nz");
			this.aList.Add("http://www.om");
			this.aList.Add("http://www.org");
			this.aList.Add("http://www.pa");
			this.aList.Add("http://www.pe");
			this.aList.Add("http://www.pf");
			this.aList.Add("http://www.pg");
			this.aList.Add("http://www.ph");
			this.aList.Add("http://www.pk");
			this.aList.Add("http://www.pl");
			this.aList.Add("http://www.pm");
			this.aList.Add("http://www.pn");
			this.aList.Add("http://www.pr");
			this.aList.Add("http://www.pt");
			this.aList.Add("http://www.pw");
			this.aList.Add("http://www.py");
			this.aList.Add("http://www.qa");
			this.aList.Add("http://www.re");
			this.aList.Add("http://www.ro");
			this.aList.Add("http://www.ru");
			this.aList.Add("http://www.rw");
			this.aList.Add("http://www.sa");
			this.aList.Add("http://www.sb");
			this.aList.Add("http://www.sc");
			this.aList.Add("http://www.sd");
			this.aList.Add("http://www.se");
			this.aList.Add("http://www.sg");
			this.aList.Add("http://www.sh");
			this.aList.Add("http://www.si");
			this.aList.Add("http://www.sj");
			this.aList.Add("http://www.sk");
			this.aList.Add("http://www.sl");
			this.aList.Add("http://www.sm");
			this.aList.Add("http://www.sn");
			this.aList.Add("http://www.so");
			this.aList.Add("http://www.sr");
			this.aList.Add("http://www.st");
			this.aList.Add("http://www.su");
			this.aList.Add("http://www.sv");
			this.aList.Add("http://www.sy");
			this.aList.Add("http://www.sz");
			this.aList.Add("http://www.tc");
			this.aList.Add("http://www.td");
			this.aList.Add("http://www.tf");
			this.aList.Add("http://www.tg");
			this.aList.Add("http://www.th");
			this.aList.Add("http://www.tj");
			this.aList.Add("http://www.tk");
			this.aList.Add("http://www.tm");
			this.aList.Add("http://www.tn");
			this.aList.Add("http://www.to");
			this.aList.Add("http://www.tp");
			this.aList.Add("http://www.tr");
			this.aList.Add("http://www.tt");
			this.aList.Add("http://www.tv");
			this.aList.Add("http://www.tw");
			this.aList.Add("http://www.tz");
			this.aList.Add("http://www.ua");
			this.aList.Add("http://www.ug");
			this.aList.Add("http://www.uk");
			this.aList.Add("http://www.um");
			this.aList.Add("http://www.us");
			this.aList.Add("http://www.uy");
			this.aList.Add("http://www.uz");
			this.aList.Add("http://www.va");
			this.aList.Add("http://www.vc");
			this.aList.Add("http://www.ve");
			this.aList.Add("http://www.vg");
			this.aList.Add("http://www.vi");
			this.aList.Add("http://www.vn");
			this.aList.Add("http://www.vu");
			this.aList.Add("http://www.wf");
			this.aList.Add("http://www.ws");
			this.aList.Add("http://www.ye");
			this.aList.Add("http://www.yt");
			this.aList.Add("http://www.yu");
			this.aList.Add("http://www.za");
			this.aList.Add("http://www.zm");
			this.aList.Add("http://www.zr");
			this.aList.Add("http://www.zw");
			this.comboBox1.SelectedIndex = 0;
			this.checkBox1.Checked = true;
			this.checkBox2.Checked = true;
			this.label7.Text = " ";
			this.timer1.Interval = 80;
			this.timer1.Start();
			this.timer2.Interval = 10000;
			this.timer3.Interval = 5000;
			this.button3.Enabled = false;
			this.button5.Enabled = false;
			this.numericUpDown4.Enabled = false;
			Control.CheckForIllegalCrossThreadCalls = false;
			this.progressBar1.Minimum = 0;
			this.progressBar1.Value = 0;
			try
			{
				StreamReader streamReader = new StreamReader("FightClub.txt");
				while (streamReader.Peek() >= 0)
				{
					string text = Convert.ToString(streamReader.ReadLine());
					this.listView1.Items.Add(text);
				}
			}
			catch
			{
				MessageBox.Show("FightClub.txt okunurken bir sorun meydana geldi.");
			}
		}

		// Token: 0x06000004 RID: 4 RVA: 0x0000662C File Offset: 0x0000482C
		public void kaynakAlGel(object url)
		{
			while (this.anahtar)
			{
				Thread.Sleep(1);
			}
			int num = (int)this.numericUpDown3.Value;
			int num2 = 0;
			this.taranan += 1U;
			this.AddToTextBox5(this.taranan.ToString());
			for (;;)
			{
				bool flag = false;
				for (;;)
				{
					try
					{
						WebRequest webRequest = WebRequest.Create(url.ToString());
						webRequest.Timeout = (int)this.numericUpDown2.Value;
						WebResponse response = webRequest.GetResponse();
						Stream responseStream = response.GetResponseStream();
						this.AddToTextBox9(url.ToString());
						StreamReader streamReader = new StreamReader(responseStream, Encoding.ASCII);
						string text = streamReader.ReadToEnd();
						this.trafik += (long)text.Length;
						this.AddToTextBox6(string.Format("{0:0,0,0,0}", this.trafik));
						string pattern = "(?<scheme>(http|https|ftp))://(?<host>(([1-9]?[0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\\.([1-9]?[0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\\.([1-9]?[0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5])\\.([1-9]?[0-9]|1[0-9]{2}|2[0-4][0-9]|25[0-5]))|[a-z](([a-z0-9-]+)?[a-z0-9])?(\\.[a-z](([a-z0-9-]+)?[a-z0-9])?)*\\.(com|net|nato|ad|ae|af|ag|ai|al|am|an|ao|arpa|ar|as|at|au|aw|az|a|ba|bb|bd|be|bf|bg|bh|biz|bi|bj|bm|bn|bo|br|bs|bt|bv|bw|by|bz|ca|cc|cf|cg|ch|ci|ck|cl|cm|cn|co|cr|cs|cu|cv|cx|cy|cz|de|dj|dk|dm|do|dz|ec|edu|ee|eg|eh|er|es|et|fi|fj|fk|fm|fo|fr|fx|ga|gb|gd|ge|gf|gh|gi|gl|gm|gn|gov|gp|gq|gr|gs|gt|gu|gw|gy|hk|hm|hn|hr|ht|hu|id|ie|il|info|int|in|io|iq|ir|is|it|jm|jo|jp|ke|kg|kh|ki|km|kn|kp|kr|kw|ky|kz|la|lb|lc|li|lk|lr|ls|lt|lu|lv|ly|ma|mc|md|mg|mh|mil|mk|ml|mm|mn|mobi|mo|mp|mq|mr|ms|mt|mu|mv|mw|mx|my|mz|na|nc|ne|nf|ng|ni|nl|no|np|nr|nt|nu|nz|om|org|pa|pe|pf|pg|ph|pk|pl|pm|pn|pr|pt|pw|py|qa|re|ro|ru|rw|sa|sb|sc|sd|se|sg|sh|si|sj|sk|sl|sm|sn|so|sr|st|su|sv|sy|sz|tc|td|tf|tg|th|tj|tk|tm|tn|to|tp|tr|tt|tv|tw|tz|ua|ug|uk|um|us|uy|uz|va|vc|ve|vg|vi|vn|vu|wf|ws|ye|yt|yu|za|zm|zr|zw))(?<path>(/([a-z0-9._~!$&'()*+,;=:@-]|%[0-9a-f]{2})*)*)(\\\\?(?<query>([a-z0-9._~!$&'()*+,;=:@/\\?-]|%[0-9a-f]{2})*))?(#(?<fragment>([a-z0-9._~!$&'()*+,;=:@/?-]|%[0-9a-f]{2})*))?";
						Regex regex = new Regex(pattern);
						MatchCollection matchCollection = regex.Matches(text);
						if (this.comboBox1.SelectedIndex == 0)
						{
							if (this.checkBox1.Checked)
							{
								if (this.checkBox2.Checked)
								{
									foreach (object obj in matchCollection)
									{
										Match match = (Match)obj;
										this.kontrolEderekEkle(match.Groups["scheme"].Value + "://" + match.Groups["host"].Value + "/");
									}
								}
								else if (!this.checkBox2.Checked)
								{
									foreach (object obj2 in matchCollection)
									{
										Match match = (Match)obj2;
										this.kontrolEderekEkle(match.Groups["scheme"].Value + "://" + match.Groups["host"].Value);
									}
								}
							}
							else if (!this.checkBox1.Checked)
							{
								if (this.checkBox2.Checked)
								{
									foreach (object obj3 in matchCollection)
									{
										Match match = (Match)obj3;
										this.kontrolEderekEkle(match.Groups["host"].Value + "/");
									}
								}
								else if (!this.checkBox2.Checked)
								{
									foreach (object obj4 in matchCollection)
									{
										Match match = (Match)obj4;
										this.kontrolEderekEkle(match.Groups["host"].Value);
									}
								}
							}
						}
						else if (this.comboBox1.SelectedIndex == 1)
						{
							if (this.checkBox1.Checked)
							{
								foreach (object obj5 in matchCollection)
								{
									Match match = (Match)obj5;
									this.kontrolEderekEkle(match.Groups["scheme"].Value + "://" + match.Groups["host"].Value + match.Groups["path"].Value);
								}
							}
							else if (!this.checkBox1.Checked)
							{
								foreach (object obj6 in matchCollection)
								{
									Match match = (Match)obj6;
									this.kontrolEderekEkle(match.Groups["host"].Value + match.Groups["path"].Value);
								}
							}
						}
						else if (this.comboBox1.SelectedIndex == 2)
						{
							if (this.checkBox1.Checked)
							{
								foreach (object obj7 in matchCollection)
								{
									Match match = (Match)obj7;
									this.kontrolEderekEkle(string.Concat(new string[]
									{
										match.Groups["scheme"].Value,
										"://",
										match.Groups["host"].Value,
										match.Groups["path"].Value,
										match.Groups["query"].Value,
										match.Groups["fragment"].Value
									}));
								}
							}
							else if (!this.checkBox1.Checked)
							{
								foreach (object obj8 in matchCollection)
								{
									Match match = (Match)obj8;
									this.kontrolEderekEkle(match.Groups["host"].Value + match.Groups["path"].Value + match.Groups["query"].Value + match.Groups["fragment"].Value);
								}
							}
						}
						this.updateProgressBar();
						this.AddToTextBox7(this.listBox1.Items.Count.ToString());
						response.Close();
						responseStream.Close();
						streamReader.Close();
						this.updateYuzde("% " + ((double)this.progressBar1.Value / (double)this.progressBar1.Maximum * 100.0).ToString());
						if (this.progressBar1.Value == this.progressBar1.Maximum)
						{
							MessageBox.Show("Tarama bitti.", "Sonuç Bildirisi", MessageBoxButtons.OK);
							this.button2.Enabled = true;
							TabPage tabPage = this.tabControl1.TabPages[0];
							tabPage.Enabled = true;
							this.timer2.Stop();
							this.timer3.Stop();
						}
					}
					catch (TimeoutException)
					{
						flag = true;
						num2++;
					}
					catch (WebException ex)
					{
						if (this.checkBox3.Checked)
						{
							if (ex.Message.Contains("503"))
							{
								if (Thread.CurrentThread.ManagedThreadId == 12)
								{
									this.anahtar = true;
									if (!this.modemReset)
									{
										this.modemReset = true;
										Thread thread = new Thread(new ThreadStart(this.modemiResetle));
										thread.Start();
									}
									while (this.anahtar)
									{
										Thread.Sleep(1);
										Application.DoEvents();
									}
									flag = true;
									break;
								}
							}
							else
							{
								if (this.anahtar)
								{
									while (this.anahtar)
									{
										Thread.Sleep(1);
										Application.DoEvents();
									}
									flag = true;
									break;
								}
								this.updateProgressBar();
								this.updateYuzde("% " + ((double)this.progressBar1.Value / (double)this.progressBar1.Maximum * 100.0).ToString());
								if (this.progressBar1.Value == this.progressBar1.Maximum)
								{
									MessageBox.Show("Tarama bitti.", "Sonuç Bildirisi", MessageBoxButtons.OK);
									this.button2.Enabled = true;
									TabPage tabPage = this.tabControl1.TabPages[0];
									tabPage.Enabled = true;
									this.timer2.Stop();
									this.timer3.Stop();
								}
							}
						}
					}
					catch
					{
						this.updateProgressBar();
						this.updateYuzde("% " + ((double)this.progressBar1.Value / (double)this.progressBar1.Maximum * 100.0).ToString());
						if (this.progressBar1.Value == this.progressBar1.Maximum)
						{
							MessageBox.Show("Tarama bitti.", "Sonuç Bildirisi", MessageBoxButtons.OK);
							this.button2.Enabled = true;
							TabPage tabPage = this.tabControl1.TabPages[0];
							tabPage.Enabled = true;
							this.timer2.Stop();
							this.timer3.Stop();
						}
					}
					if (!flag || num2 >= num)
					{
						return;
					}
				}
			}
		}

		// Token: 0x06000005 RID: 5 RVA: 0x000071B8 File Offset: 0x000053B8
		private void modemiResetle()
		{
			lock (this)
			{
				if (this.checkBox3.Checked && this.textBox1.Text != "")
				{
					this.button3.Enabled = false;
					this.AddToTextBox9("<-- Modem reset başladı -->");
					Process process = new Process();
					process.StartInfo.FileName = this.textBox1.Text;
					process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
					process.Start();
					process.WaitForExit();
					int exitCode = process.ExitCode;
					process.Close();
					this.AddToTextBox9("<-- Modem resetlendi. " + this.numericUpDown4.Value + " sn tolerans -->");
					Thread.Sleep((int)this.numericUpDown4.Value * 1000);
					this.AddToTextBox9("<-- Modem tolerans süresi bitti. Şimdi bağlantı için bekleniyor -->");
					this.modemReset2 = true;
				}
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000072E4 File Offset: 0x000054E4
		private void modemiResetle2()
		{
			this.AddToTextBox9("<-- Modem reset başladı -->");
			Process process = new Process();
			process.StartInfo.FileName = this.textBox1.Text;
			process.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
			process.Start();
			process.WaitForExit();
			int exitCode = process.ExitCode;
			process.Close();
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00007344 File Offset: 0x00005544
		private void AddToListBox(string str)
		{
			if (base.InvokeRequired)
			{
				base.BeginInvoke(new Action<string>(this.AddToListBox), new object[]
				{
					str
				});
			}
			else if (!this.listBox1.Items.Contains(str))
			{
				this.listBox1.Items.Add(str);
			}
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000073AC File Offset: 0x000055AC
		private void AddToTextBox4(string str)
		{
			if (base.InvokeRequired)
			{
				base.BeginInvoke(new Action<string>(this.AddToTextBox4), new object[]
				{
					str
				});
			}
			else
			{
				this.textBox4.Text = str;
			}
		}

		// Token: 0x06000009 RID: 9 RVA: 0x000073F8 File Offset: 0x000055F8
		private void AddToTextBox5(string str)
		{
			if (base.InvokeRequired)
			{
				base.BeginInvoke(new Action<string>(this.AddToTextBox5), new object[]
				{
					str
				});
			}
			else
			{
				this.textBox5.Text = str;
			}
		}

		// Token: 0x0600000A RID: 10 RVA: 0x00007444 File Offset: 0x00005644
		private void AddToTextBox6(string str)
		{
			if (base.InvokeRequired)
			{
				base.BeginInvoke(new Action<string>(this.AddToTextBox6), new object[]
				{
					str
				});
			}
			else
			{
				this.textBox6.Text = str;
			}
		}

		// Token: 0x0600000B RID: 11 RVA: 0x00007490 File Offset: 0x00005690
		private void AddToTextBox7(string str)
		{
			if (base.InvokeRequired)
			{
				base.BeginInvoke(new Action<string>(this.AddToTextBox7), new object[]
				{
					str
				});
			}
			else
			{
				this.textBox7.Text = str;
			}
		}

		// Token: 0x0600000C RID: 12 RVA: 0x000074DC File Offset: 0x000056DC
		private void AddToTextBox8(string str)
		{
			if (base.InvokeRequired)
			{
				base.BeginInvoke(new Action<string>(this.AddToTextBox8), new object[]
				{
					str
				});
			}
			else
			{
				this.textBox8.Text = str;
			}
		}

		// Token: 0x0600000D RID: 13 RVA: 0x00007528 File Offset: 0x00005728
		private void AddToTextBox9(string str)
		{
			if (base.InvokeRequired)
			{
				base.BeginInvoke(new Action<string>(this.AddToTextBox9), new object[]
				{
					str
				});
			}
			else
			{
				this.textBox9.AppendText(str + "\r\n");
			}
		}

		// Token: 0x0600000E RID: 14 RVA: 0x0000757C File Offset: 0x0000577C
		private void AddToTextBox2(string str)
		{
			if (base.InvokeRequired)
			{
				base.BeginInvoke(new Action<string>(this.AddToTextBox2), new object[]
				{
					str
				});
			}
			else
			{
				this.textBox2.Text = str;
			}
		}

		// Token: 0x0600000F RID: 15 RVA: 0x000075C8 File Offset: 0x000057C8
		private void updateYuzde(string str)
		{
			if (base.InvokeRequired)
			{
				base.BeginInvoke(new Action<string>(this.updateYuzde), new object[]
				{
					str
				});
			}
			else
			{
				this.groupBox8.Text = str;
			}
		}

		// Token: 0x06000010 RID: 16 RVA: 0x00007628 File Offset: 0x00005828
		private void updateProgressBar()
		{
			if (base.InvokeRequired)
			{
				this.progressBar1.Invoke(new MethodInvoker(delegate()
				{
					this.progressBar1.Value++;
				}));
			}
			else
			{
				this.progressBar1.Value++;
			}
		}

		// Token: 0x06000011 RID: 17 RVA: 0x00007680 File Offset: 0x00005880
		private void kontrolEderekEkle(string urlSon)
		{
			urlSon.Trim();
			if (!urlSon.Contains("webcache.google") && !urlSon.Contains("google.com") && !urlSon.Contains("cc.bingj.com") && !urlSon.Contains("help.live.com"))
			{
				if (!this.aList.Contains(urlSon))
				{
					this.AddToListBox(urlSon);
				}
			}
		}

		// Token: 0x06000012 RID: 18 RVA: 0x000076EC File Offset: 0x000058EC
		private void timer1_Tick(object sender, EventArgs e)
		{
			this.label7.Text = this.label7.Text.Substring(1) + this.label7.Text[0].ToString();
			ThreadPool.GetMaxThreads(out this.maxWorkerThreads, out this.maxCompletionPortThreads);
			ThreadPool.GetAvailableThreads(out this.avail, out this.worker);
			this.AddToTextBox2((this.maxWorkerThreads - this.avail).ToString());
		}

		// Token: 0x06000013 RID: 19 RVA: 0x00007778 File Offset: 0x00005978
		private void button4_Click(object sender, EventArgs e)
		{
			SaveFileDialog saveFileDialog = new SaveFileDialog();
			saveFileDialog.Title = "Listeyi kaydet";
			saveFileDialog.Filter = "txt dosyaları (*.txt)|*.txt|Tüm dosyalar (*.*)|*.*";
			saveFileDialog.FileName = "";
			if (saveFileDialog.ShowDialog() == DialogResult.OK)
			{
				StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName.ToString());
				for (int i = 0; i <= this.listBox1.Items.Count - 1; i++)
				{
					streamWriter.WriteLine(this.listBox1.Items[i].ToString());
				}
				this.textBox10.AppendText(saveFileDialog.FileName.ToString() + "\r\n");
				streamWriter.Flush();
				streamWriter.Close();
			}
		}

		// Token: 0x06000014 RID: 20 RVA: 0x00007848 File Offset: 0x00005A48
		private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (this.comboBox1.SelectedIndex == 1)
			{
				this.checkBox2.Enabled = false;
			}
			else if (this.comboBox1.SelectedIndex == 2)
			{
				this.checkBox2.Enabled = false;
			}
			else if (this.comboBox1.SelectedIndex == 0)
			{
				this.checkBox2.Enabled = true;
			}
		}

		// Token: 0x06000015 RID: 21 RVA: 0x000078C6 File Offset: 0x00005AC6
		private void button3_Click(object sender, EventArgs e)
		{
			this.anahtar = true;
			this.button3.Enabled = false;
			this.button5.Enabled = true;
		}

		// Token: 0x06000016 RID: 22 RVA: 0x000078EA File Offset: 0x00005AEA
		private void button5_Click(object sender, EventArgs e)
		{
			this.anahtar = false;
			this.button3.Enabled = true;
			this.button5.Enabled = false;
		}

		// Token: 0x06000017 RID: 23 RVA: 0x00007910 File Offset: 0x00005B10
		private void button2_Click(object sender, EventArgs e)
		{
			if (this.textBox3.Text == "")
			{
				MessageBox.Show("Ayarlar bölümünü eksik doldurdunuz", "Uyarı", MessageBoxButtons.OK);
			}
			else
			{
				this.button2.Enabled = false;
				this.button3.Enabled = true;
				this.button5.Enabled = false;
				TabPage tabPage = this.tabControl1.TabPages[0];
				tabPage.Enabled = false;
				int num = (int)this.numericUpDown1.Value;
				int num2 = (int)this.numericUpDown5.Value;
				ThreadPool.SetMinThreads(num2, num2);
				ThreadPool.SetMaxThreads(num, num);
				string[] array = this.textBox3.Text.Split(new char[]
				{
					'\n'
				});
				int num3 = 0;
				for (int i = 0; i < array.Length; i++)
				{
					string text = array[i].Trim();
					if (text != "")
					{
						num3++;
					}
				}
				this.progressBar1.Maximum = this.listView1.CheckedItems.Count * num3;
				this.AddToTextBox4(this.progressBar1.Maximum.ToString());
				for (int j = 0; j <= this.listView1.CheckedItems.Count - 1; j++)
				{
					for (int k = 0; k < array.Length; k++)
					{
						string text = array[k].Trim();
						if (text != "")
						{
							string state = this.listView1.CheckedItems[j].Text.Replace("{Ux0r_Arama_Key}", text);
							ThreadPool.QueueUserWorkItem(new WaitCallback(this.kaynakAlGel), state);
							Application.DoEvents();
						}
					}
				}
				this.timer2.Start();
				this.timer3.Start();
			}
		}

		// Token: 0x06000018 RID: 24 RVA: 0x00007B30 File Offset: 0x00005D30
		private void timer2_Tick(object sender, EventArgs e)
		{
			this.textBox9.Clear();
			if (this.modemReset2)
			{
				Thread thread = new Thread(new ThreadStart(this.deneme));
				thread.Start();
				if (this.a1)
				{
					this.modemReset = false;
					this.modemReset2 = false;
					this.anahtar = false;
					this.button3.Enabled = true;
					this.a1 = false;
				}
			}
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00007BAC File Offset: 0x00005DAC
		private void button1_Click(object sender, EventArgs e)
		{
			if (this.textBox1.Text == "")
			{
				MessageBox.Show("Modem ayarlarını tam girmediniz.");
			}
			else
			{
				Thread thread = new Thread(new ThreadStart(this.modemiResetle2));
				thread.Start();
			}
		}

		// Token: 0x0600001A RID: 26 RVA: 0x00007C00 File Offset: 0x00005E00
		private void timer3_Tick(object sender, EventArgs e)
		{
			long num = this.trafik - this.tutulan;
			this.AddToTextBox8((num / 5000L).ToString() + " Kb/s");
			this.tutulan = this.trafik;
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00007C4C File Offset: 0x00005E4C
		private void button6_Click(object sender, EventArgs e)
		{
			OpenFileDialog openFileDialog = new OpenFileDialog();
			openFileDialog.Filter = "bat dosyaları (*.bat)|*.bat|Tüm dosyalar (*.*)|*.*";
			openFileDialog.Title = "Bat dosyası seç";
			if (openFileDialog.ShowDialog() == DialogResult.OK)
			{
				this.textBox1.Text = openFileDialog.FileName;
			}
		}

		// Token: 0x0600001C RID: 28 RVA: 0x00007C9C File Offset: 0x00005E9C
		private void checkBox3_CheckedChanged(object sender, EventArgs e)
		{
			if (this.checkBox3.Checked)
			{
				this.numericUpDown4.Enabled = true;
			}
			else
			{
				this.numericUpDown4.Enabled = false;
			}
		}

		// Token: 0x0600001D RID: 29 RVA: 0x00007CDC File Offset: 0x00005EDC
		private void numericUpDown5_ValueChanged(object sender, EventArgs e)
		{
			if (this.numericUpDown5.Value > this.numericUpDown1.Value)
			{
				NumericUpDown numericUpDown = this.numericUpDown5;
				numericUpDown.Value = --numericUpDown.Value;
				Application.DoEvents();
				MessageBox.Show("Minimum kanal sayısı maximum kanal sayısından büyük olamaz!");
			}
		}

		// Token: 0x0600001E RID: 30 RVA: 0x00007D38 File Offset: 0x00005F38
		private void numericUpDown1_ValueChanged(object sender, EventArgs e)
		{
			if (this.numericUpDown1.Value < this.numericUpDown5.Value)
			{
				NumericUpDown numericUpDown = this.numericUpDown1;
				numericUpDown.Value = ++numericUpDown.Value;
				Application.DoEvents();
				MessageBox.Show("Maximum kanal sayısı minimum kanal sayısından büyük olamaz!");
			}
		}

		// Token: 0x0600001F RID: 31 RVA: 0x00007D94 File Offset: 0x00005F94
		private void button7_Click(object sender, EventArgs e)
		{
			for (int i = 0; i <= this.listView1.Items.Count - 1; i++)
			{
				this.listView1.Items[i].Checked = true;
			}
		}

		// Token: 0x06000020 RID: 32 RVA: 0x00007DE0 File Offset: 0x00005FE0
		private void button8_Click(object sender, EventArgs e)
		{
			for (int i = 0; i <= this.listView1.Items.Count - 1; i++)
			{
				this.listView1.Items[i].Checked = false;
			}
		}

		// Token: 0x04000001 RID: 1
		private bool a1 = false;

		// Token: 0x04000002 RID: 2
		public bool modemReset = false;

		// Token: 0x04000003 RID: 3
		public bool modemReset2 = false;

		// Token: 0x04000004 RID: 4
		private ArrayList aList = new ArrayList();

		// Token: 0x04000005 RID: 5
		public int worker = 0;

		// Token: 0x04000006 RID: 6
		public int avail = 0;

		// Token: 0x04000007 RID: 7
		public int maxWorkerThreads = 0;

		// Token: 0x04000008 RID: 8
		public int maxCompletionPortThreads = 0;

		// Token: 0x04000009 RID: 9
		public uint taranan = 0U;

		// Token: 0x0400000A RID: 10
		public long trafik = 0L;

		// Token: 0x0400000B RID: 11
		private byte[] buf = new byte[4096];

		// Token: 0x0400000C RID: 12
		public bool anahtar = false;

		// Token: 0x0400000D RID: 13
		private long tutulan = 0L;

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupBox9_Enter(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }

        private void button10_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }

        private void button11_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_MouseDown(object sender, MouseEventArgs e)
        {
			mov = 1;
			movX = e.X;
			movY = e.Y;
		}

        private void panel1_MouseUp(object sender, MouseEventArgs e)
        {
			mov = 0;
		}

        private void panel1_MouseMove(object sender, MouseEventArgs e)
        {
			if (mov == 1)
            {
				this.SetDesktopLocation(MousePosition.X - movX, MousePosition.Y - movY);
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
			Application.Exit();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
			System.Media.SoundPlayer ses = new System.Media.SoundPlayer();
			ses.SoundLocation = "c729xh.wav";
			ses.Play();

		}
    }
}
