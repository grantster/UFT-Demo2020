/***************************************************************
    *  DO NOT EDIT THIS FILE!
    *         
    *  This file is automatically generated by HP Service Test.
    *  Manually changing the contents of this file may result in 
    *  loss of information.
    *          
    *  To edit the test, open the file ‘Flight_API_WSDL.st’ 
    *  in HP Service Test.
     ***************************************************************/
    
    namespace Script
    {
    using System;
    using System.Text;
    using System.Threading;
    using System.Xml;
    using System.Xml.Schema;
    using HP.ST.Fwk.ReporterFWK;
    using HP.ST.Shared.Utilities;
    using HP.ST.Ext.BindingImpl.Getters;
    using HP.ST.Ext.BindingImpl.Setters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.PropInfo;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Getters;
    using HP.ST.Fwk.RunTimeFWK.BindingFWK.Setters;
    using HP.ST.Fwk.RunTimeFWK;
    using HP.ST.Fwk.RunTimeFWK.Utilities;
    using HP.ST.Fwk.RunTimeFWK.HelperClasses;
    using HP.ST.Fwk.RunTimeFWK.CompositeActivities;
    using HP.ST.Ext.BindingImpl.Setters.DataSourceSetters;
    using HP.ST.Fwk.JVMLoader;
    using System.IO;
    using System.Collections.Generic;
    using System.Reflection;
    using HP.ST.Fwk.SOAReplayAPI;
    using HP.ST.Fwk.UFTLicensing;
    
    
    
    public partial class WorkFlowScript : STWorkFlowScriptBase
    {    
    	TestUserCode _userCode = null;
    	TestEntities _flow = null;
    	static Reporter reporter;
    	int reportLevelInTree;
        HP.ST.Fwk.ReportCreator.QTPEngine.QTPEngineReportCreator reportCreator;
    	
    	public BindDirection bind_dir2 = null;
        
        public IEnumerable<FeaturesGroup> LicensedFeatures
        {
        
        get
        {
        List<FeaturesGroup> features = new List<FeaturesGroup>();
        return features;
        
        }
        
        }
        
        public WorkFlowScript()
            : base(VuserClass.CommandLineArguments, new STRunTimeContext(), "test")
        {	
        	UpdateContextWithActionFolder(String.Empty);
        	
        }
        
        public WorkFlowScript(ISTRunTimeContext ctx)
            : base(VuserClass.CommandLineArguments, ctx, "test")
            
        {
        	this._context = ctx;
        	UpdateContextWithActionFolder(String.Empty);
        	UpdateTestSettings(ctx);
        }
        
        internal void InitializeComponent()
        {
        	LoadInput();
        	
        	InitReport();
        	
        	InitializeEncryptionManagerValues();
        
        	_userCode = new TestUserCode();
            _flow = _userCode;
            _flow.Context=this._context;
            
            
        
        	_flow.StartActivity1 = new HP.ST.Ext.BasicActivities.StartActivity(_context,"StartActivity1");
            _flow.Loop2 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Loop<Loop2Input>(_context,"Loop2",LoopType.For);
            _flow.EndActivity3 = new HP.ST.Ext.BasicActivities.EndActivity(_context,"EndActivity3");
            _flow.Sequence7 = new HP.ST.Fwk.RunTimeFWK.CompositeActivities.Sequence(_context,"Sequence7");
            _flow.StServiceCallActivity4 = new HP.ST.Ext.WebServicesActivities.StServiceCallActivity(_context,"StServiceCallActivity4");
            _flow.StServiceCallActivity6 = new HP.ST.Ext.WebServicesActivities.StServiceCallActivity(_context,"StServiceCallActivity6");
            _flow.StartActivity1.Comment = @"";
            _flow.StartActivity1.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_code_activity.png";
            _flow.StartActivity1.Name = @"Start";
            _flow.StartActivity1.JVM = new HP.ST.Ext.BasicActivities.JVMProperties();
            _flow.StartActivity1.IsJavaUsed = false;
            _flow.StartActivity1.JVM.Classpath = @"%CLASSPATH%";
            _flow.StartActivity1.JVM.AdditionalVMParameters = @"";
            _flow.StartActivity1.JMS = new HP.ST.Ext.BasicActivities.JMSProperties();
            _flow.StartActivity1.IsJmsUsed = false;
            _flow.StartActivity1.JMS.JNDIContextFactory = @"<Select...>";
            _flow.StartActivity1.JMS.JNDIProviderUrl = @"";
            _flow.StartActivity1.JMS.JMSConnectionFactory = @"";
            _flow.StartActivity1.JMS.SecurityPrincipal = @"";
            _flow.StartActivity1.JMS.SecurityCredentials = @"";
            _flow.StartActivity1.JMS.JMSClientID = @"";
            _flow.StartActivity1.JMS.SSLPassword = @"";
            _flow.StartActivity1.JMS.SSLTrustedCertificate = @"";
            _flow.StartActivity1.JMS.SSLIdentity = @"";
            _flow.StartActivity1.JMS.ConnectionsPerProcess = @"1";
            _flow.StartActivity1.JMS.TimeoutOptions = @"DN_User_defined_Timeout";
            _flow.StartActivity1.JMS.UserTimeout = @"20";
            _flow.StartActivity1.JMS.GenerateAutoSelector = @"No";
            this.Activities.Add (_flow.StartActivity1);
            _flow.Loop2.ConditionAsString = @"Run for 1 iteration";
            _flow.Loop2.NumberOfIterations = (int)1;
            _flow.Loop2.Comment = @"";
            _flow.Loop2.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_loop.png";
            _flow.Loop2.Name = @"Test Flow";
            _flow.Loop2.Activities.Add (_flow.Sequence7);
            this.Activities.Add (_flow.Loop2);
            _flow.EndActivity3.Comment = @"";
            _flow.EndActivity3.IconPath = @"AddIns\ServiceTest\BasicActivities\toolbox_code_activity.png";
            _flow.EndActivity3.Name = @"End";
            this.Activities.Add (_flow.EndActivity3);
            _flow.Sequence7.Comment = @"";
            _flow.Sequence7.IconPath = @"";
            _flow.Sequence7.Name = @"Sequence7";
            _flow.Sequence7.Activities.Add (_flow.StServiceCallActivity4);
            _flow.Sequence7.Activities.Add (_flow.StServiceCallActivity6);
            XmlDocument StServiceCallActivity4_InputEnvelope_Document = new XmlDocument();
            StServiceCallActivity4_InputEnvelope_Document.PreserveWhitespace = true;
            StServiceCallActivity4_InputEnvelope_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><GetFlights xmlns=""HP.SOAQ.SampleApp""><DepartureCity>Denver</DepartureCity><ArrivalCity>Frankfurt</ArrivalCity><FlightDate>2020-04-01T00:00:00-06:00</FlightDate></GetFlights></Body></Envelope>");
            _flow.StServiceCallActivity4.InputEnvelope = StServiceCallActivity4_InputEnvelope_Document;
            _flow.StServiceCallActivity4.Comment = @"";
            _flow.StServiceCallActivity4.IconPath = @"AddIns\ServiceTest\WSImportTechnology\ictb_service_operations_16.png";
            _flow.StServiceCallActivity4.Name = @"GetFlights";
            _flow.StServiceCallActivity4.TransportProtocol.SOAPProperties.EndpointAddress = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity4.TransportProtocol.SOAPProperties.EndpointAddress}")) ? @"http://localhost:8000/Flights_SOAP" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity4.TransportProtocol.SOAPProperties.EndpointAddress}");
            _flow.StServiceCallActivity4.TransportProtocol.SOAPProperties.SoapAction = @"HP.SOAQ.SampleApp/IFlightsSoapService/GetFlights";
            _flow.StServiceCallActivity4.TransportProtocol.SOAPProperties.ContentType = @"text/xml; charset=utf-8";
            _flow.StServiceCallActivity4.TransportProtocol.SOAPProperties.Timeout = (int)100000;
            _flow.StServiceCallActivity4.Service = @"Flights_Service";
            _flow.StServiceCallActivity4.Port = @"FlightsServiceMethods";
            _flow.StServiceCallActivity4.Operation = @"GetFlights";
            _flow.StServiceCallActivity4.IsOneWay = false;
            _flow.StServiceCallActivity4.SendRequestToService=true;
            _flow.StServiceCallActivity4.FaultExpected=false;
            _flow.StServiceCallActivity4.IsAsync=false;
            _flow.StServiceCallActivity4.TargetNamespace=@"http://tempuri.org/";
            _flow.StServiceCallActivity4.ListenOnPort = (int)0;
            XmlDocument StServiceCallActivity4_ExpectedOutputAttachments_Document = new XmlDocument();
            StServiceCallActivity4_ExpectedOutputAttachments_Document.PreserveWhitespace = true;
            StServiceCallActivity4_ExpectedOutputAttachments_Document.LoadXml(
@"<OutputAttachments />");
            _flow.StServiceCallActivity4.ExpectedOutputAttachments = StServiceCallActivity4_ExpectedOutputAttachments_Document;
            XmlDocument StServiceCallActivity4_ExpectedFaultProperties_Document = new XmlDocument();
            StServiceCallActivity4_ExpectedFaultProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity4_ExpectedFaultProperties_Document.LoadXml(
@"<tns:Envelope xmlns:tns=""http://schemas.xmlsoap.org/soap/envelope/""><tns:Body><tns:Fault><faultcode /><faultstring /></tns:Fault></tns:Body></tns:Envelope>");
            _flow.StServiceCallActivity4.ExpectedFaultProperties = StServiceCallActivity4_ExpectedFaultProperties_Document;
            XmlDocument StServiceCallActivity4_ExpectedOutputProperties_Document = new XmlDocument();
            StServiceCallActivity4_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity4_ExpectedOutputProperties_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><GetFlightsResponse xmlns=""HP.SOAQ.SampleApp"" /></Body></Envelope>");
            _flow.StServiceCallActivity4.ExpectedOutputProperties = StServiceCallActivity4_ExpectedOutputProperties_Document;
            set_StServiceCallActivity4_checkpoints(_flow.StServiceCallActivity4);
            XmlDocument StServiceCallActivity6_InputEnvelope_Document = new XmlDocument();
            StServiceCallActivity6_InputEnvelope_Document.PreserveWhitespace = true;
            StServiceCallActivity6_InputEnvelope_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/"" xmlns:p1=""http://www.w3.org/2001/XMLSchema-instance""><Body><CreateFlightOrder xmlns=""HP.SOAQ.SampleApp""><FlightOrder><Class>Business</Class><CustomerName>David Grant</CustomerName><DepartureDate>{Step.InputProperties.StServiceCallActivity4.Body.GetFlights.FlightDate}</DepartureDate><FlightNumber>15809</FlightNumber><NumberOfTickets>2</NumberOfTickets></FlightOrder></CreateFlightOrder></Body></Envelope>");
            _flow.StServiceCallActivity6.InputEnvelope = StServiceCallActivity6_InputEnvelope_Document;
            _flow.StServiceCallActivity6.Comment = @"";
            _flow.StServiceCallActivity6.IconPath = @"AddIns\ServiceTest\WSImportTechnology\ictb_service_operations_16.png";
            _flow.StServiceCallActivity6.Name = @"CreateFlightOrder";
            _flow.StServiceCallActivity6.TransportProtocol.SOAPProperties.EndpointAddress = String.IsNullOrEmpty(_context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity6.TransportProtocol.SOAPProperties.EndpointAddress}")) ? @"http://localhost:8000/Flights_SOAP" : _context.ResourceManager.GetValue(@"{Step.GeneralProperties.StServiceCallActivity6.TransportProtocol.SOAPProperties.EndpointAddress}");
            _flow.StServiceCallActivity6.TransportProtocol.SOAPProperties.SoapAction = @"HP.SOAQ.SampleApp/IFlightsSoapService/CreateFlightOrder";
            _flow.StServiceCallActivity6.TransportProtocol.SOAPProperties.ContentType = @"text/xml; charset=utf-8";
            _flow.StServiceCallActivity6.TransportProtocol.SOAPProperties.Timeout = (int)100000;
            _flow.StServiceCallActivity6.Service = @"Flights_Service";
            _flow.StServiceCallActivity6.Port = @"FlightsServiceMethods";
            _flow.StServiceCallActivity6.Operation = @"CreateFlightOrder";
            _flow.StServiceCallActivity6.IsOneWay = false;
            _flow.StServiceCallActivity6.SendRequestToService=true;
            _flow.StServiceCallActivity6.FaultExpected=false;
            _flow.StServiceCallActivity6.IsAsync=false;
            _flow.StServiceCallActivity6.TargetNamespace=@"http://tempuri.org/";
            _flow.StServiceCallActivity6.ListenOnPort = (int)0;
            VTDPropertyInfoBase pi3 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='GetFlights'][1]/*[local-name(.)='FlightDate'][1]");
            VTDBaseGetter binding_getter2 = new VTDXPathGetter(pi3,XmlTypeCode.DateTime);
            VTDPropertyInfoBase pi4 = new VTDPropertyInfoBase("InputEnvelope","/*[local-name(.)='Envelope'][1]/*[local-name(.)='Body'][1]/*[local-name(.)='CreateFlightOrder'][1]/*[local-name(.)='FlightOrder'][1]/*[local-name(.)='DepartureDate'][1]");
            VTDBaseSetter binding_setter2 = new VTDXPathSetter(pi4,XmlTypeCode.DateTime);
            bind_dir2 = new BindDirection(_flow.StServiceCallActivity4,binding_getter2,binding_setter2,BindTargetType.ToInProperty);
            _flow.StServiceCallActivity6.InDirections.Add(bind_dir2);
            XmlDocument StServiceCallActivity6_ExpectedOutputAttachments_Document = new XmlDocument();
            StServiceCallActivity6_ExpectedOutputAttachments_Document.PreserveWhitespace = true;
            StServiceCallActivity6_ExpectedOutputAttachments_Document.LoadXml(
@"<OutputAttachments />");
            _flow.StServiceCallActivity6.ExpectedOutputAttachments = StServiceCallActivity6_ExpectedOutputAttachments_Document;
            XmlDocument StServiceCallActivity6_ExpectedFaultProperties_Document = new XmlDocument();
            StServiceCallActivity6_ExpectedFaultProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity6_ExpectedFaultProperties_Document.LoadXml(
@"<tns:Envelope xmlns:tns=""http://schemas.xmlsoap.org/soap/envelope/""><tns:Body><tns:Fault><faultcode /><faultstring /></tns:Fault></tns:Body></tns:Envelope>");
            _flow.StServiceCallActivity6.ExpectedFaultProperties = StServiceCallActivity6_ExpectedFaultProperties_Document;
            XmlDocument StServiceCallActivity6_ExpectedOutputProperties_Document = new XmlDocument();
            StServiceCallActivity6_ExpectedOutputProperties_Document.PreserveWhitespace = true;
            StServiceCallActivity6_ExpectedOutputProperties_Document.LoadXml(
@"<Envelope xmlns=""http://schemas.xmlsoap.org/soap/envelope/""><Body><CreateFlightOrderResponse xmlns=""HP.SOAQ.SampleApp""><CreateFlightOrderResult><OrderNumber>100</OrderNumber><TotalPrice>1000</TotalPrice></CreateFlightOrderResult></CreateFlightOrderResponse></Body></Envelope>");
            _flow.StServiceCallActivity6.ExpectedOutputProperties = StServiceCallActivity6_ExpectedOutputProperties_Document;
            set_StServiceCallActivity6_checkpoints(_flow.StServiceCallActivity6);
            
        }
        
        internal void InitializeEncryptionManagerValues()
        {
        
        }
        	
    	bool useReport = true;
    
    	protected override STExecutionResult ExecuteStep()
        {
            return base.ExecuteStep();
        }
    
        public void Start()
        {
    	    try
    		{
    		  Workflow_Executing();
    		  this.ExecuteStep();
    		}
    		finally
    		{
    		  WorkFlowScript_Completed();
    		}
        }
    
    	private void InitReport()
    	{
    		if (useReport)
    		{	
    			// Intialize Reporter
    			string reportDBDir = Path.Combine(this._context.ReportDirectory, @"Report");
    			CleanupReport(reportDBDir);        	
    			string reportDBPath = Path.Combine(reportDBDir, "VTDReport.mdb");        	
    			if (reporter == null)
    			{
    				reporter = new Reporter(reportDBPath);
    			}
    			_context.Reporter = reporter;
    		}
    	}
    
        public static void CopyDirectory(string Src, string Dst)
        {
            String[] Files;
    
            if (Dst[Dst.Length - 1] != Path.DirectorySeparatorChar)
                Dst += Path.DirectorySeparatorChar;
            if (!Directory.Exists(Dst)) Directory.CreateDirectory(Dst);
            Files = Directory.GetFileSystemEntries(Src);
            foreach (string Element in Files)
            {
                // Sub directories
                if (Directory.Exists(Element))
                    CopyDirectory(Element, Dst + Path.GetFileName(Element));
                // Files in directory
                else
                    File.Copy(Element, Dst + Path.GetFileName(Element), true);
            }
        }
        
        private void CleanupReport(string reportDBDir)
        {   
    		if (useReport)
    		{             
    			string reportTemplateDir = Path.Combine(ServiceTestRunner.GetInstallPath(),@"bin\ReportResources");                
    			try
    			{
            		CopyDirectory(reportTemplateDir, reportDBDir);
    			}
    			catch //(Exception ex)
    			{
    				//ToDo: LoggingService.Warn("Report Cleanup Error", ex);
    			}
    		}
        }
    
        void Workflow_Executing()
        {   
        	InitReportNode();
                       
        }
    
    	private void InitReportNode()
    	{
    		if (useReport)
    		{	
        		// Init report creator
    			this.reportCreator = new HP.ST.Fwk.ReportCreator.QTPEngine.QTPEngineReportCreator();
    			this.reportLevelInTree = reportCreator.Init(_context.EnvironmentProfile.GetVariableValue("TestName"), _context);
                
    			STActivityBase activity = this;
    			string workflowID = activity.GetHashCode().ToString();
    			ReportNodeCreationData newNodeData =
    			new ReportNodeCreationData(workflowID, workflowID, DateTime.Now);
    			reporter.CreateReportNode(newNodeData);
            
    			ReportInfoData newReportData = new ReportInfoData(workflowID, ReportKeywords.TypeKeywordTag, this.GetType().ToString());
    			reporter.SendReportData(newReportData);
    			newReportData = new ReportInfoData(workflowID, ReportKeywords.NameKeywordTag, this.Name);
    			//TrackData(ReportInfoData.InfoDataTag, newReportData);
    			reporter.SendReportData(newReportData);            
            }
    	}
        
        void WorkFlowScript_Completed()
        {   
    		
    
    		CreateReportFiles();
    					
        	// Write all snapshots to disk
    		this._context.SnapshotManager.WriteSnapshotsToDisk();
    
    		OnExecutionCompleted();
    		
        }
    
    	private void CreateReportFiles()
    	{
    		if (useReport)
    		{	
    			//Dispose reporter inorder to close connection to report DB
           		this._context.Reporter.Dispose();
            	
           		// Run report creator
    			reportCreator.RunOnDBAndCreateFiles();
    		}
    	}
    
        
        void Workflow_Faulting()
        {
    		
    
    		CreateReportFiles();
            // Write all snapshots to disk
    		this._context.SnapshotManager.WriteSnapshotsToDisk();
           
    		OnExecutionCompleted();
        }
    
    	protected override QcSystemVariables GetRuntimeQcVariables(ISTRunTimeContext context)
    	{
    		return new HP.ST.Ext.BasicActivities.RuntimeQcVariables(this._context);
    	}
            
    	protected override TestSystemVariables GetTestSystemVariables(ISTRunTimeContext context)
    	{
    		return new HP.ST.Ext.BasicActivities.RuntimeTestVariables(this._context);
    	}
    
    	private void UpdateTestSettings(ISTRunTimeContext ctx)
        {
    		ctx.PropertyBag["StopTestOnStepFailure"] = true;
    	}
    }
    
    public partial class VuserClass
    {
    	public static string[] CommandLineArguments;
    	public static string[] DotNetResolverPaths;
    	
        public VuserClass()
        {
    				
    		AssemblyResolver.AddSTPathsToResolutionPaths();
    		AssemblyResolver.AttachToAppdomain();
        }
    
        private void AddAssemblyResolver()
        {
    		AssemblyResolver.AddTestPathToResolutionPaths(GetTestPath());
    		AssemblyResolver.AddPathsForAssemblyResolution(DotNetResolverPaths);
        }
    	
        public int STAction()
        {	
            AddAssemblyResolver();
            STRunTimeContext ctx = new STRunTimeContext(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName, string.Empty);
            WorkFlowScript script = new WorkFlowScript(ctx);
            script.InitializeComponent();
            script.Start();       
            
            return 0;
        }
        
        public void NotifyLicenseException(string msg)
        {
        		
    		try
    		{
    		    STRunTimeContext ctx = new STRunTimeContext(Directory.GetParent(Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location)).FullName, string.Empty);
                WorkFlowScript script = new WorkFlowScript(ctx);
                script.InitializeComponent();
                script.Context.ReplayClient.OnLicenseFailure(msg);
                
            }
            catch (Exception)
            {
    			// ToDo: log the error message
            }        
        }
    
    	 protected string GetTestPath()
            {
                if (CommandLineArguments != null)
                {
                    for (int i = 0; i < CommandLineArguments.Length; i++)
                    {
                        if (CommandLineArguments[i].Equals("-test", StringComparison.OrdinalIgnoreCase))
                        {
                            return CommandLineArguments[i + 1];
                        }
                    }
                }
                return String.Empty;
            }
        
    }
    
    }
    