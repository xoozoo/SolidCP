// Copyright (c) 2016, SolidCP
// SolidCP is distributed under the Creative Commons Share-alike license
// 
// SolidCP is a fork of WebsitePanel:
// Copyright (c) 2015, Outercurve Foundation.
// All rights reserved.
//
// Redistribution and use in source and binary forms, with or without modification,
// are permitted provided that the following conditions are met:
//
// - Redistributions of source code must  retain  the  above copyright notice, this
//   list of conditions and the following disclaimer.
//
// - Redistributions in binary form  must  reproduce the  above  copyright  notice,
//   this list of conditions  and  the  following  disclaimer in  the documentation
//   and/or other materials provided with the distribution.
//
// - Neither  the  name  of  the  Outercurve Foundation  nor   the   names  of  its
//   contributors may be used to endorse or  promote  products  derived  from  this
//   software without specific prior written permission.
//
// THIS SOFTWARE IS PROVIDED BY THE COPYRIGHT HOLDERS AND CONTRIBUTORS "AS IS" AND
// ANY EXPRESS OR IMPLIED WARRANTIES, INCLUDING,  BUT  NOT  LIMITED TO, THE IMPLIED
// WARRANTIES  OF  MERCHANTABILITY   AND  FITNESS  FOR  A  PARTICULAR  PURPOSE  ARE
// DISCLAIMED. IN NO EVENT SHALL THE COPYRIGHT HOLDER OR CONTRIBUTORS BE LIABLE FOR
// ANY DIRECT, INDIRECT, INCIDENTAL,  SPECIAL,  EXEMPLARY, OR CONSEQUENTIAL DAMAGES
// (INCLUDING, BUT NOT LIMITED TO,  PROCUREMENT  OF  SUBSTITUTE  GOODS OR SERVICES;
// LOSS OF USE, DATA, OR PROFITS; OR BUSINESS INTERRUPTION)  HOWEVER  CAUSED AND ON
// ANY  THEORY  OF  LIABILITY,  WHETHER  IN  CONTRACT,  STRICT  LIABILITY,  OR TORT
// (INCLUDING NEGLIGENCE OR OTHERWISE)  ARISING  IN  ANY WAY OUT OF THE USE OF THIS
// SOFTWARE, EVEN IF ADVISED OF THE POSSIBILITY OF SUCH DAMAGE.

using System;
using System.Collections.Generic;
using System.Text;

namespace SolidCP.Providers.DNS
{
    public class DnsRecord
    {
        private string recordName;
        private DnsRecordType recordType;
        private string recordData;
        private int mxPriority;
        private string recordText;
        private int srvPriority;
        private int srvWeight;
        private int srvPort;
        private int recordTTL;


        public string RecordName
        {
            get { return this.recordName; }
            set { this.recordName = value; }
        }

        public DnsRecordType RecordType
        {
            get { return this.recordType; }
            set { this.recordType = value; }
        }

        public string RecordData
        {
            get { return this.recordData; }
            set { this.recordData = value; }
        }

        public int RecordTTL
        {
            get { return this.recordTTL; }
            set { this.recordTTL = value; }
        }

        public int MxPriority
        {
            get { return this.mxPriority; }
            set { this.mxPriority = value; }
        }

        public string RecordText
        {
            get { return this.recordText; }
            set { this.recordText = value; }
        }


        public int SrvPriority
        {
            get { return this.srvPriority; }
            set { this.srvPriority = value; }
        }

        public int SrvWeight
        {
            get { return this.srvWeight; }
            set { this.srvWeight = value; }
        }

        public int SrvPort
        {
            get { return this.srvPort; }
            set { this.srvPort = value; }
        }

    }
}
