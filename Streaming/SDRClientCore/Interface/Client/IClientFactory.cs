﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.ATLC.SDR.ClientCore.Interface.Result;
using Microsoft.ATLC.SDR.ClientCore.Interface.Audio;
using Microsoft.ProjectOxford.SpeakerRecognition;
using Microsoft.ProjectOxford.SpeakerRecognition.Contract.Identification;

namespace Microsoft.ATLC.SDR.ClientCore.Interface.Client
{
    /// <summary>
    /// SDR Client Factory
    /// </summary>
    public interface IClientFactory : IDisposable
    {
        /// <summary>
        /// Creates new SDR recognition client
        /// </summary>
        /// <param name="clientId">Id associated with all requests related to this client</param>
        /// <param name="speakerIds">Speaker ids for recognition</param>
        /// <param name="stepSize">Frequency of sending requests to the server in seconds. 
        /// If set to 1, the client will send a request to the server for every second received from the user</param>
        /// <param name="windowSize">Windows size in seconds</param>
        /// <param name="audioFormat">Audio format</param>
        /// <param name="resultCallBack">Value callback action consisted of identification result, client id and request id</param>
        /// <param name="serviceClient">Client used in identifying the streamed audio file</param>
        /// <returns>SDR recognition client</returns>
        IRecognitionClient CreateRecognitionClient(Guid clientId, Guid[] speakerIds, int stepSize, int windowSize, IAudioFormat audioFormat, Action<IRecognitionResult> resultCallBack, SpeakerIdentificationServiceClient serviceClient);
    }
}
