// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.
namespace Microsoft.Azure.Management.Graph.RBAC.Fluent
{
    using System.Threading;
    using System.Threading.Tasks;
    using Microsoft.Azure.Management.Graph.RBAC.Fluent.CertificateCredential.Definition;
    using Microsoft.Azure.Management.Graph.RBAC.Fluent.CertificateCredential.UpdateDefinition;
    using Microsoft.Azure.Management.Graph.RBAC.Fluent.Models;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResource.Definition;
    using Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResource.Update;
    using System;
    using System.IO;

    public partial class CertificateCredentialImpl<T> where T : class
    {
        /// <summary>
        /// Export the information of this service principal into an auth file.
        /// </summary>
        /// <param name="privateKeyPath">The path to the private key file.</param>
        /// <return>The next stage in credential definition.</return>
        CertificateCredential.UpdateDefinition.IWithAuthFileCertificatePassword<T> CertificateCredential.UpdateDefinition.IWithAuthFileCertificate<T>.WithPrivateKeyFile(string privateKeyPath)
        {
            return this.WithPrivateKeyFile(privateKeyPath);
        }

        /// <summary>
        /// Export the information of this service principal into an auth file.
        /// </summary>
        /// <param name="privateKeyPath">The path to the private key file.</param>
        /// <return>The next stage in credential definition.</return>
        CertificateCredential.Definition.IWithAuthFileCertificatePassword<T> CertificateCredential.Definition.IWithAuthFileCertificate<T>.WithPrivateKeyFile(string privateKeyPath)
        {
            return this.WithPrivateKeyFile(privateKeyPath);
        }

        /// <summary>
        /// Specifies the public key for an asymmetric X509 certificate.
        /// </summary>
        /// <param name="certificate">The certificate content.</param>
        /// <return>The next stage in credential definition.</return>
        CertificateCredential.UpdateDefinition.IWithAttach<T> CertificateCredential.UpdateDefinition.IWithPublicKey<T>.WithPublicKey(byte[] certificate)
        {
            return this.WithPublicKey(certificate);
        }

        /// <summary>
        /// Specifies the public key for an asymmetric X509 certificate.
        /// </summary>
        /// <param name="certificate">The certificate content.</param>
        /// <return>The next stage in credential definition.</return>
        CertificateCredential.Definition.IWithAttach<T> CertificateCredential.Definition.IWithPublicKey<T>.WithPublicKey(byte[] certificate)
        {
            return this.WithPublicKey(certificate);
        }

        /// <summary>
        /// Gets the name of the resource.
        /// </summary>
        string Microsoft.Azure.Management.ResourceManager.Fluent.Core.IHasName.Name
        {
            get
            {
                return this.Name();
            }
        }

        /// <summary>
        /// Gets the resource ID string.
        /// </summary>
        string Microsoft.Azure.Management.ResourceManager.Fluent.Core.IHasId.Id
        {
            get
            {
                return this.Id();
            }
        }

        /// <summary>
        /// Custom Key Identifier. If the credential is defined by .NET SDK with name,
        /// it would be the base64 encoding of name. If it is set by other tools, it would
        /// be that value. Otherwise, it would usually be the thumbprint of certificate.
        /// </summary>
        string ICertificateCredential.CustomKeyIdentifier
        {
            get
            {
                return this.CustomKeyIdentifier();
            }
        }

        /// <summary>
        /// Export the information of this service principal into an auth file.
        /// </summary>
        /// <param name="outputStream">The output stream to export the file.</param>
        /// <return>The next stage in credential definition.</return>
        CertificateCredential.UpdateDefinition.IWithAuthFileCertificate<T> CertificateCredential.UpdateDefinition.IWithAuthFile<T>.WithAuthFileToExport(StreamWriter outputStream)
        {
            return this.WithAuthFileToExport(outputStream);
        }

        /// <summary>
        /// Export the information of this service principal into an auth file.
        /// </summary>
        /// <param name="outputStream">The output stream to export the file.</param>
        /// <return>The next stage in credential definition.</return>
        CertificateCredential.Definition.IWithAuthFileCertificate<T> CertificateCredential.Definition.IWithAuthFile<T>.WithAuthFileToExport(StreamWriter outputStream)
        {
            return this.WithAuthFileToExport(outputStream);
        }

        /// <summary>
        /// Specifies the duration for which password or key would be valid. Default value is 1 year.
        /// </summary>
        /// <param name="duration">The duration of validity.</param>
        /// <return>The next stage in credential definition.</return>
        CertificateCredential.UpdateDefinition.IWithAttach<T> CertificateCredential.UpdateDefinition.IWithDuration<T>.WithDuration(TimeSpan duration)
        {
            return this.WithDuration(duration);
        }

        /// <summary>
        /// Specifies the duration for which password or key would be valid. Default value is 1 year.
        /// </summary>
        /// <param name="duration">The duration of validity.</param>
        /// <return>The next stage in credential definition.</return>
        CertificateCredential.Definition.IWithAttach<T> CertificateCredential.Definition.IWithDuration<T>.WithDuration(TimeSpan duration)
        {
            return this.WithDuration(duration);
        }

        /// <summary>
        /// Gets start date.
        /// </summary>
        System.DateTime Microsoft.Azure.Management.Graph.RBAC.Fluent.ICredential.StartDate
        {
            get
            {
                return this.StartDate();
            }
        }

        /// <summary>
        /// Gets key value.
        /// </summary>
        string Microsoft.Azure.Management.Graph.RBAC.Fluent.ICredential.Value
        {
            get
            {
                return this.Value();
            }
        }

        /// <summary>
        /// Gets end date.
        /// </summary>
        System.DateTime Microsoft.Azure.Management.Graph.RBAC.Fluent.ICredential.EndDate
        {
            get
            {
                return this.EndDate();
            }
        }

        /// <summary>
        /// Attaches the child definition to the parent resource update.
        /// </summary>
        /// <return>The next stage of the parent definition.</return>
        T Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResource.Update.IInUpdate<T>.Attach()
        {
            return this.Attach();
        }

        /// <summary>
        /// Export the information of this service principal into an auth file.
        /// </summary>
        /// <param name="privateKeyPassword">The password for the private key.</param>
        /// <return>The next stage in credential definition.</return>
        CertificateCredential.UpdateDefinition.IWithAttach<T> CertificateCredential.UpdateDefinition.IWithAuthFileCertificatePassword<T>.WithPrivateKeyPassword(string privateKeyPassword)
        {
            return this.WithPrivateKeyPassword(privateKeyPassword);
        }

        /// <summary>
        /// Export the information of this service principal into an auth file.
        /// </summary>
        /// <param name="privateKeyPassword">The password for the private key.</param>
        /// <return>The next stage in credential definition.</return>
        CertificateCredential.Definition.IWithAttach<T> CertificateCredential.Definition.IWithAuthFileCertificatePassword<T>.WithPrivateKeyPassword(string privateKeyPassword)
        {
            return this.WithPrivateKeyPassword(privateKeyPassword);
        }

        /// <summary>
        /// Attaches the child definition to the parent resource definiton.
        /// </summary>
        /// <return>The next stage of the parent definition.</return>
        T Microsoft.Azure.Management.ResourceManager.Fluent.Core.ChildResource.Definition.IInDefinition<T>.Attach()
        {
            return this.Attach();
        }

        /// <summary>
        /// Specifies the type of the certificate to be symmetric.
        /// </summary>
        /// <return>The next stage in credential definition.</return>
        CertificateCredential.UpdateDefinition.IWithSymmetricKey<T> CertificateCredential.UpdateDefinition.IWithCertificateType<T>.WithSymmetricEncryption()
        {
            return this.WithSymmetricEncryption();
        }

        /// <summary>
        /// Specifies the type of the certificate to be asymmetric X509.
        /// </summary>
        /// <return>The next stage in credential definition.</return>
        CertificateCredential.UpdateDefinition.IWithPublicKey<T> CertificateCredential.UpdateDefinition.IWithCertificateType<T>.WithAsymmetricX509Certificate()
        {
            return this.WithAsymmetricX509Certificate();
        }

        /// <summary>
        /// Specifies the type of the certificate to be symmetric.
        /// </summary>
        /// <return>The next stage in credential definition.</return>
        CertificateCredential.Definition.IWithSymmetricKey<T> CertificateCredential.Definition.IWithCertificateType<T>.WithSymmetricEncryption()
        {
            return this.WithSymmetricEncryption();
        }

        /// <summary>
        /// Specifies the type of the certificate to be Asymmetric X509.
        /// </summary>
        /// <return>The next stage in credential definition.</return>
        CertificateCredential.Definition.IWithPublicKey<T> CertificateCredential.Definition.IWithCertificateType<T>.WithAsymmetricX509Certificate()
        {
            return this.WithAsymmetricX509Certificate();
        }

        /// <summary>
        /// Specifies the secret key for a symmetric encryption.
        /// </summary>
        /// <param name="secret">The secret key content.</param>
        /// <return>The next stage in credential definition.</return>
        CertificateCredential.UpdateDefinition.IWithAttach<T> CertificateCredential.UpdateDefinition.IWithSymmetricKey<T>.WithSecretKey(byte[] secret)
        {
            return this.WithSecretKey(secret);
        }

        /// <summary>
        /// Specifies the secret key for a symmetric encryption.
        /// </summary>
        /// <param name="secret">The secret key content.</param>
        /// <return>The next stage in credential definition.</return>
        CertificateCredential.Definition.IWithAttach<T> CertificateCredential.Definition.IWithSymmetricKey<T>.WithSecretKey(byte[] secret)
        {
            return this.WithSecretKey(secret);
        }

        /// <summary>
        /// Specifies the start date after which password or key would be valid. Default value is current time.
        /// </summary>
        /// <param name="startDate">The start date for validity.</param>
        /// <return>The next stage in credential definition.</return>
        CertificateCredential.UpdateDefinition.IWithAttach<T> CertificateCredential.UpdateDefinition.IWithStartDate<T>.WithStartDate(DateTime startDate)
        {
            return this.WithStartDate(startDate);
        }

        /// <summary>
        /// Specifies the start date after which password or key would be valid. Default value is current time.
        /// </summary>
        /// <param name="startDate">The start date for validity.</param>
        /// <return>The next stage in credential definition.</return>
        CertificateCredential.Definition.IWithAttach<T> CertificateCredential.Definition.IWithStartDate<T>.WithStartDate(DateTime startDate)
        {
            return this.WithStartDate(startDate);
        }
    }
}