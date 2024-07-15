using AvaloniaUITheSeriesGTKMVVM.Services;
using CommunityToolkit.Mvvm.Messaging.Messages;

namespace AvaloniaUITheSeriesGTKMVVM.Messages;

public class LoginSuccessMessage(AuthenticationResult result) : ValueChangedMessage<AuthenticationResult>(result);
