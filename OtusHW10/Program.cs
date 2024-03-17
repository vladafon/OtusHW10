using OtusHW10;
using OtusHW10.Core.NumberComparing;
using OtusHW10.Core.NumberGenerator;
using OtusHW10.Infrastructure.Configuration;

var fileConfigReader = new FileConfigurationReader();
var config = fileConfigReader.GetGameConfig();

var numberGenerator = new RandomNumberGenerator();
var numberComparer = new NumberComparer();

var consoleGameProcessor = new ConsoleGameProcessor(numberGenerator, numberComparer);

await consoleGameProcessor.StartGameAsync(config.NumberFrom, config.NumberTo, config.AttemptsCount);
