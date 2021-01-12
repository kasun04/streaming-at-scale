output "eventhub_namespace_name" {
  value       = azurerm_eventhub_namespace.main.name
  description = "The event hub namespace."
}

output "eventhub_name" {
  value       = azurerm_eventhub.main.name
  description = "The event hub name."
}

output "send_primary_connection_string" {
  value       = azurerm_eventhub_authorization_rule.send.primary_connection_string
  description = "The primary connection string to send events."
  sensitive   = true
}

output "send_secondary_connection_string" {
  value       = azurerm_eventhub_authorization_rule.send.secondary_connection_string
  description = "The secondary connection string to send events."
  sensitive   = true
}

output "listen_primary_connection_string" {
  value       = azurerm_eventhub_authorization_rule.listen.primary_connection_string
  description = "The primary connection string to receive events."
  sensitive   = true
}
